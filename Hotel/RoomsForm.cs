using DevExpress.XtraEditors.Camera;
using Hotel.Databases;
using Hotel.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Hotel
{

    public partial class RoomsForm : Form
    {
        public Timer fromDateTimer = new Timer();
        RoomEntity roomSelected = new RoomEntity();
        bool isEditCustomer = false;
        CustomerEntity currCustomer = null;

        public RoomsForm()
        {
            InitializeComponent();
            this.initRoomListView();
            infoLockPanel.Enabled = false;
            // this.autoUpdateTime();
            this.initDateTime();
            this.resetValidation();
        }

        private void resetValidation()
        {
            this.fullnameEL.Hide();
            this.idEL.Hide();
            this.phoneEL.Hide();
        }

        private void initDateTime()
        {
            this.fromDatePicker.Value = DateTime.Now;
            this.fromTimePicker.Time = DateTime.Now;
            this.toDatePicker.Value = DateTime.Now;
            this.toTimePicker.Time = DateTime.Now;
            this.toDatePicker.MinDate = DateTime.Now;
        }
        private void autoUpdateTime()
        {
            fromDateTimer.Tick += new EventHandler((Object myObject, EventArgs myEventArgs) =>
            {
                if (this.isEditCustomer) return;
                this.fromDatePicker.Value = DateTime.Now;
                this.fromTimePicker.Time = DateTime.Now;
            });
            fromDateTimer.Interval = 5000;
            fromDateTimer.Start();
        }

        public void initRoomListView()
        {
            new Thread(() =>
            {
                RoomDB db = new RoomDB();
                DataTable dt = new DataTable();
                db.getAllAdapter(@"
                    room.room_id as [ID],
                    room.[name] as [Tên bàn],
                    CASE WHEN booking.booking_id IS NULL THEN N'Trống' ELSE N'Có người' END as [Tình trạng]
            ").Fill(dt);

                if (dt.Rows.Count <= 0) return;

                this.tableListView.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    this.tableListView.Items.Add(new ListViewItem()
                    {
                        Text = row.Field<string>(1),
                        ImageIndex = row.Field<string>(2) == "Trống" ? 0 : 1,
                        Position = Point.Empty,
                        Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    });
                }
            }).Start();
        }

        private void loadData()
        {
            this.initRoomListView();
            this.tableListView_SelectedIndexChanged(null, null);
            this.initEditBooking();
        }

        private void tableListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tableListView.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = this.tableListView.SelectedIndices[0];

            string text = tableListView.Items[intselectedindex].Text;
            RoomDB db = new RoomDB();
            DataTable dt = new DataTable();
            db.getAllAdapter(@"
                room.room_id,
                room.[name] as [Tên bàn],
				CASE WHEN booking.booking_id IS NULL THEN 0 ELSE 1 END as is_busy,
				room.[desc],
                room.price_per_hour,
				booking.booking_id
            ").Fill(dt);

            if (dt.Rows.Count <= 0) return;

            foreach (DataRow row in dt.Rows)
            {
                if (row.Field<string>(1) == text)
                {
                    this.roomSelected = new RoomEntity()
                    {
                        room_id = row.Field<int>(0),
                        name = row.Field<string>(1),
                        is_busy = row.Field<int>(2) == 1,
                        desc = row.Field<string>(3),
                        price_per_hour = long.Parse(row.Field<long>(4).ToString())
                    };

                    if (this.roomSelected.is_busy)
                    {
                        this.roomSelected.booking_id = row.Field<int>(5);
                    }
                    break;
                }
            }

            this.currTableLabel.Text = this.roomSelected.name;
            this.roomDescLabel.Text = this.roomSelected.desc;
            this.pricePerHoursLabel.Text = Currency.formatPrice(this.roomSelected.price_per_hour);
            this.initEditBooking();
        }

        private void initEditBooking()
        {
            BookingDB db = new BookingDB();

            if (this.roomSelected == null || this.roomSelected?.booking_id <= 0)
            {
                this.totalPriceLabel.Text = "0";
                return;
            }

            int booking_id = this.roomSelected.booking_id;

            BookingEntity booking = db.getById(booking_id);
            if (booking == null)
                return;

            this.fromDatePicker.Value = booking.created_at;
            this.fromTimePicker.Time = booking.created_at;
            this.toDatePicker.Value = booking.expire_at;
            this.toTimePicker.Time = booking.expire_at;

            this.totalPriceLabel.Text = Currency.formatPrice(0);
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            using (Checkout checkout = new Checkout(this.roomSelected.room_id, this.roomSelected.name, this.roomSelected.booking_id))
            {
                if (checkout.ShowDialog() == DialogResult.OK)
                {
                    this.loadData();
                }
            }
        }
        private void rentButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
                return;

            DateTime fromDateTime = DateTime.Now;

            DateTime toDate = this.toDatePicker.Value;
            DateTime toTime = this.toTimePicker.Time;
            DateTime toDateTime = new DateTime(toDate.Year, toDate.Month, toDate.Day, toTime.Hour, toTime.Minute, toTime.Second);

            if (fromDateTime > toDateTime)
            {
                MessageBox.Show("Ngày bắt đầu không được trước ngày thuê!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // First Create / Update Customer
            CustomerEntity customer = new CustomerEntity()
            {
                fullname = this.fullnameTextBox.Text,
                phone = this.phoneTextBox.Text,
                id_card = this.idTexBox.Text
            };

            CustomerDB customerDB = new CustomerDB();
            if (this.isEditCustomer)
            {
                customerDB.update(this.currCustomer.customer_id, customer);
            }
            else
            {
                int newId = customerDB.create(customer);
                this.currCustomer = customer;
                this.currCustomer.customer_id = newId;
                MessageBox.Show("Tạo khách hàng mới thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            BookingDB db = new BookingDB();
            Guid randId = Guid.NewGuid();

            BookingEntity booking = new BookingEntity()
            {
                expire_at = toDateTime,
                room_id = this.roomSelected.room_id,
                customer_id = this.currCustomer.customer_id,
                key_code = randId.ToString()
            };

            db.create(booking);

            MessageBox.Show("Tạo phòng thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.initRoomListView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Bạn có chắc muốn hủy đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            BookingDB db = new BookingDB();
            if (db.cancel(this.roomSelected.booking_id)) { 
                MessageBox.Show("Hủy phòng thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
        }

        private void handleFindPhone()
        {
            CustomerDB db = new CustomerDB();
            CustomerEntity found = db.getByPhone(this.phoneTextBox.Text);

            if (found == null)
            {
                this.isEditCustomer = false;
            }
            else
            {
                this.fullnameTextBox.Text = found.fullname;
                this.idTexBox.Text = found.id_card;
                this.isEditCustomer = true;
                this.currCustomer = found;
            }

            this.infoLockPanel.Enabled = true;
        }

        private void findPhoneButton_Click(object sender, EventArgs e)
        {
            this.handleFindPhone();
        }

        private void takePicButton_Click(object sender, EventArgs e)
        {


            TakePictureDialog takePic = new TakePictureDialog();
            if (takePic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image pic = (takePic.Image);
                this.picPicture.Image = HanldeImage.cropToRect(pic);
            }
        }

        private void fullnameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.fullnameTextBox, this.fullnameEL);
            vali.required();
        }

        private void phoneTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.phoneTextBox, this.phoneEL);
            vali.required().isPhone();
        }

        private void idTexBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.idTexBox, this.idEL);
            vali.required();
        }

        #region Validate keypress
        private void fullnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress vali = new ValidateKeyPress(sender, e);
            vali.justAllowAlphabet();
        }

        private void idTexBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress vali = new ValidateKeyPress(sender, e);
            vali.justAllowNumber();
        }
        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.handleFindPhone();
            }
            ValidateKeyPress vali = new ValidateKeyPress(sender, e);
            vali.justAllowNumber();
        }
        #endregion

        private void phoneTextBox_Leave(object sender, EventArgs e)
        {
            this.handleFindPhone();
        }

        private void tableListView_Click(object sender, EventArgs e)
        {
            this.tableListView_SelectedIndexChanged(null, null);
        }
    }
}

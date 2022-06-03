﻿using Hotel.Databases;
using Hotel.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Hotel
{

    public partial class RoomsForm : Form
    {
        public Timer fromDateTimer = new Timer();
        RoomEntity roomSelected = new RoomEntity();
        public RoomsForm()
        {
            InitializeComponent();
            this.initRoomListView();
            infoLockPanel.Enabled = false;

            this.fromDatePicker.Value = DateTime.Now;
            this.fromTimePicker.Time = DateTime.Now;
            this.toDatePicker.Value = DateTime.Now;
            this.toTimePicker.Time = DateTime.Now;
            this.toDatePicker.MinDate = DateTime.Now;
        }
        private void TablesForm_Load(object sender, EventArgs e)
        {
            fromDateTimer.Tick += new EventHandler((Object myObject, EventArgs myEventArgs) =>
            {
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
            this.updatePrice();
        }

        private void tableListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tableListView.SelectedIndices.Count <= 0)
                return;

            int intselectedindex = this.tableListView.SelectedIndices[0];
            if (intselectedindex < 0)
            {
                this.currTableLabel.Text = "Chọn phòng để tiếp tục";
                this.roomDescLabel.Text = "Nội dung";
            };

            string text = tableListView.Items[intselectedindex].Text;
            RoomDB db = new RoomDB();
            DataTable dt = new DataTable();
            db.getAllAdapter(@"
                room.room_id,
                room.[name] as [Tên bàn],
				CASE WHEN booking.booking_id IS NULL THEN 0 ELSE 1 END as is_busy,
				room.[desc],
				room.room_id
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
                        desc = row.Field<string>(3)
                    };

                    if (this.roomSelected.is_busy)
                    {
                        this.roomSelected.order_number = row.Field<int>(4);
                    }
                    break;
                }
            }

            this.currTableLabel.Text = this.roomSelected.name;
            this.roomDescLabel.Text = this.roomSelected.desc;
            this.updatePrice();
        }

        private void updatePrice()
        {
            BookingDB db = new BookingDB();

            if (this.roomSelected == null)
            {
                this.totalPriceLabel.Text = Currency.formatPrice(0);
                return;
            }

            int order_number = this.roomSelected.order_number;

            if (order_number <= 0)
            {
                this.totalPriceLabel.Text = Currency.formatPrice(0);
                return;
            }

            this.totalPriceLabel.Text = Currency.formatPrice(db.getTotalPriceOfOrder(this.roomSelected.order_number));
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            using (Checkout checkout = new Checkout(this.roomSelected.room_id, this.roomSelected.name, this.roomSelected.order_number))
            {
                if (checkout.ShowDialog() == DialogResult.OK)
                {
                    this.loadData();
                }
            }
        }

        private void toTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        private void rentButton_Click(object sender, EventArgs e)
        {
            DateTime fromDateTime = DateTime.Now;

            DateTime toDate = this.toDatePicker.Value;
            DateTime toTime = this.toTimePicker.Time;
            DateTime toDateTime = new DateTime(toDate.Year, toDate.Month, toDate.Day, toTime.Hour, toTime.Minute, toTime.Second);

            if (fromDateTime > toDateTime)
            {
                MessageBox.Show("Ngày bắt đầu không được trước ngày thuê!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BookingDB db = new BookingDB();
            Guid randId = Guid.NewGuid();

            BookingEntity booking = new BookingEntity()
            {
                expire_at = toDateTime,
                room_id = this.roomSelected.room_id,
                customer_id = 1,
                key_code = randId.ToString()
            };

            db.create(booking);
        }

    }
}
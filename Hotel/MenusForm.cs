using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using Hotel.Databases;
using Hotel.Entities;

namespace Hotel
{
    public partial class MenusForm : Form
    {
        public MenusForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.initCreateProduct();
            this.initCreateRoom();
        }
        private void MenusForm_Load(object sender, EventArgs e)
        {
            this.LoadProductTableData();
            this.LoadTableTableData();
        }

        #region Product controller
        bool isEditProduct = false;
        ProductEntity product = null;


        private void initEditProduct()
        {
            this.isEditProduct = true;
            this.prdSubmitButton.Text = "Cập nhật";
            this.productActionLabel.Text = $"Chỉnh sửa thực đơn id: {product.product_id}";
            this.prodDeleteButton.Show();
            this.resetValidationProduct();

            this.prdNameTextBox.Text = this.product.name;
            this.prdUnitTextBox.Text = this.product.unit;
            this.prdStockTextBox.Text = this.product.stock.ToString();
            this.prodPriceTextBox.Text = this.product.price.ToString();
        }
        private void initCreateProduct()
        {
            this.isEditProduct = false;
            this.prdSubmitButton.Text = "Tạo";
            this.productActionLabel.Text = "Thêm thực đơn";
            this.prodDeleteButton.Hide();
            this.resetValidationProduct();

            this.prdNameTextBox.Text = "";
            this.prdUnitTextBox.Text = "";
            this.prdStockTextBox.Text = "";
            this.prodPriceTextBox.Text = "";
        }

        private void resetValidationProduct()
        {
            this.prodNameEL.Hide();
            this.prdUnitEL.Hide();
            this.prodStockEL.Hide();
            this.prodPriceEL.Hide();
        }

        public void LoadProductTableData()
        {
            ProductDB db = new ProductDB();
            new Thread(() =>
            {
                DataTable dt = new DataTable();
                db.getAllAdapter(
                        @"
                            product.product_id as ID, 
                            name as [Tên thực đơn],
                            price as [Giá bán],
                            unit as [Đơn vị],
                            stock as [Hàng tồn],
                            CASE WHEN product.stock > 0 THEN N'Còn hàng' ELSE N'Hết hàng' END as [Trạng thái]
                        ",
                        this.searchProductTextBox.Text
                    )
                .Fill(dt);

                this.Invoke(new MethodInvoker(delegate
                {
                    this.productTable.DataSource = dt;
                }));

            }).Start();
            new Thread(() =>
            {
                int totalCount = db.count();
                this.productTableLabel.Text = $"Danh sách thực đơn ({totalCount})";
            }).Start();
        }

        private void productTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIndex = this.productTable.CurrentCell.RowIndex;
            if (currentIndex < 0) return;

            DataGridViewRow row = this.productTable.Rows[currentIndex];
            this.product = new ProductEntity()
            {
                product_id = Int32.Parse(row.Cells["ID"].Value.ToString()),
                name = row.Cells["Tên thực đơn"].Value.ToString(),
                unit = row.Cells["Đơn vị"].Value.ToString(),
                stock = Int32.Parse(row.Cells["Hàng tồn"].Value.ToString()),
                price = Int64.Parse(row.Cells["Giá bán"].Value.ToString()),
            };

            this.isEditProduct = true;
            initEditProduct();
        }

        private void clearProductButton_Click(object sender, EventArgs e)
        {
            this.initCreateProduct();
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Bạn có chắc muốn xóa [{this.product.name}]?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            ProductDB db = new ProductDB();
            new Thread(() =>
            {
                db.delete(this.product.product_id);
                this.LoadProductTableData();
                this.initCreateProduct();
            }).Start();
        }

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            this.LoadProductTableData();
        }

        private void submitProductButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
                return;

            ProductEntity newProduct = new ProductEntity()
            {
                name = this.prdNameTextBox.Text,
                unit = this.prdUnitTextBox.Text,
                stock = Int32.Parse(this.prdStockTextBox.Text),
                price = Int32.Parse(this.prodPriceTextBox.Text),
            };

            ProductDB db = new ProductDB();
            if (isEditProduct)
            {
                if (db.update(this.product.product_id, newProduct))
                    MessageBox.Show("Cập nhật thực đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (db.createProduct(newProduct))
                    MessageBox.Show("Tạo thực đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.initCreateProduct();
            }
            this.LoadProductTableData();
        }

        #region VALIDATIONS -----------------------------
        private void prdNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.prdNameTextBox, this.prodNameEL);
            if (string.IsNullOrEmpty(this.prdNameTextBox.Text))
            {
                vali.error("Vui lòng nhập ô này!");
                return;
            }
            vali.normal();
        }
        private void prdUnitTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.prdUnitTextBox, this.prdUnitEL);
            if (string.IsNullOrEmpty(this.prdUnitTextBox.Text))
            {
                vali.error("Vui lòng nhập ô này!");
                return;
            }
            vali.normal();
        }
        private void prdStockTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            TextBoxValidation vali = new TextBoxValidation(e, this.prdStockTextBox, this.prodStockEL);
            if (string.IsNullOrEmpty(this.prdStockTextBox.Text))
            {
                vali.error("Vui lòng nhập ô này!");
                return;
            }
            vali.normal();
        }
        private void prodPriceTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.prodPriceTextBox, this.prodPriceEL);
            if (string.IsNullOrEmpty(this.prodPriceTextBox.Text))
            {
                vali.error("Vui lòng nhập ô này!");
                return;
            }
            vali.normal();
        }
        private void prdStockTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress vali = new ValidateKeyPress(sender, e);
            vali.justAllowNumber();
        }
        private void prodPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress vali = new ValidateKeyPress(sender, e);
            vali.justAllowNumber();
        }
        #endregion

        #endregion

        #region Room Config

        bool isEditRoom = false;
        RoomEntity room = null;
        private void initEditRoom()
        {
            this.isEditRoom = true;
            this.roomSubmitButton.Text = "Cập nhật";
            this.tableTableLabel.Text = $"Chỉnh sửa phòng id: {room.room_id}";

            this.roomNameTextBox.Text = this.room.name;
            this.roomDescTextBox.Text = this.room.desc;
            this.roomPricePerHourTextBox.Text = this.room.price_per_hour.ToString();

            this.roomDeleteButton.Show();
        }

        private void initCreateRoom()
        {
            this.isEditRoom = false;
            this.roomSubmitButton.Text = "Thêm";
            this.actionTableLabel.Text = "Thêm bàn";

            this.roomNameTextBox.Text = "";
            this.roomDescTextBox.Text = "";
            this.roomPricePerHourTextBox.Text = "";

            this.roomNameTextBox.Text = "";
            this.roomDeleteButton.Hide();
        }

        public void LoadTableTableData()
        {
            RoomDB db = new RoomDB();
            new Thread(() =>
            {
                DataTable dt = new DataTable();
                db.getAllAdapter(
                        @"
                           	room.room_id as [ID],
                            room.[name] as [Tên bàn],
                            room.[desc] as [Nội dung],
                            price_per_hour as [Tiền theo giờ],
                            CASE WHEN booking.booking_id IS NULL THEN N'Trống' ELSE N'Có người' END as [Tình trạng]
                        ",
                        this.roomSearchTextBox.Text
                    )
                .Fill(dt);

                this.Invoke(new MethodInvoker(delegate
                {
                    this.tableTable.DataSource = dt;
                }));

            }).Start();
            new Thread(() =>
            {
                int totalCount = db.count();
                this.tableTableLabel.Text = $"Danh sách bàn ({totalCount})";
            }).Start();
        }

        private void submitTableButton_Click(object sender, EventArgs e)
        {
            RoomEntity newRoom = new RoomEntity()
            {
                name = this.roomNameTextBox.Text,
                desc = this.roomDescTextBox.Text,
                price_per_hour = long.Parse(this.roomPricePerHourTextBox.Text) 
            };
            RoomDB db = new RoomDB();
            new Thread(() =>
            {
                if (isEditRoom)
                {
                    if (db.update(room.room_id, newRoom))
                        MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (db.create(newRoom))
                        MessageBox.Show("Tạo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.LoadTableTableData();
            }).Start();
        }
        private void tableTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIndex = this.tableTable.CurrentCell.RowIndex;
            if (currentIndex < 0) return;

            DataGridViewRow row = this.tableTable.Rows[currentIndex];
            this.room = new RoomEntity()
            {
                room_id = Int32.Parse(row.Cells["ID"].Value.ToString()),
                name = row.Cells["Tên bàn"].Value.ToString(),
                desc = row.Cells["Nội dung"].Value.ToString(),
                price_per_hour = long.Parse(row.Cells["Tiền theo giờ"].Value.ToString())
            };
            initEditRoom();
        }

        private void clearTableButton_Click(object sender, EventArgs e)
        {
            this.initCreateRoom();
        }

        private void deleteTableButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Bạn có chắc muốn xóa [{room.name}]?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            RoomDB db = new RoomDB();
            new Thread(() =>
            {
                db.delete(this.room.room_id);
                this.LoadTableTableData();
                this.initCreateRoom();
            }).Start();
        }

        private void searchTableButton_Click(object sender, EventArgs e)
        {
            this.LoadTableTableData();
        }

        #endregion

        private void roomPricePerHourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress vali = new ValidateKeyPress(sender, e);
            vali.justAllowNumber();
        }
    }
}

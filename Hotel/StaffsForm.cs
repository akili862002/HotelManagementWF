using Hotel.Databases;
using Hotel.Entities;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Hotel
{
    public partial class StaffsForm : Form
    {
        StaffEntity staff = null;
        bool isEditStaff;
        bool isValidPhoneNumber = false;

        public StaffsForm()
        {
            InitializeComponent();
        }
        private void StaffsForm_Load(object sender, EventArgs e)
        {
            this.initCreateUser();
            this.LoadStaffTableData();
            birthdatePicker.Format = DateTimePickerFormat.Custom;
            birthdatePicker.CustomFormat = "MM/dd/yyyy";
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(opnfd.FileName);
                Console.WriteLine("w: " + img.Width);
                Console.WriteLine("h: " + img.Height);
                if (img.Width != img.Height)
                {
                    MessageBox.Show(String.Format("Please select a square image! ({0}x{1})", img.Width, img.Height), "Error");
                    return;
                }
            }
        }
        public void LoadStaffTableData()
        {
            StaffDB db = new StaffDB();
            new Thread(() =>
            {
                DataTable dt = new DataTable();
                db.getAllAdapter(
                        @"
                            staff_id as [ID], 
                            fullname as [Họ Và Tên],
                            phone as [Điện Thoại],
                            [password] as [Mật khẩu],
                            birthdate as [Ngày Sinh],
                            gender as [Giới Tính],
                            address as [Địa Chỉ],
                            salary as [Lương],
                            CASE WHEN is_reception = 1 THEN N'Tiếp tân' ELSE N'Lao công' END as [Chức vụ]
                        ",
                        this.searchTextBox.Text
                    )
                .Fill(dt);

                this.Invoke(new MethodInvoker(delegate
                {
                    this.staffsTable.DataSource = dt;
                }));

            }).Start();
            new Thread(() =>
            {
                int totalCount = db.count();
                this.gunaLabel6.Text = $"Danh sách Nhân viên ({totalCount})";
            }).Start();
        }
        private void initCreateUser()
        {
            this.resetValidation();
            this.isEditStaff = false;
            this.submitButton.Text = "Thêm";
            this.gunaLabel3.Text = $"Thêm nhân viên";
            this.deleteButton.Show();

            this.fullnameTextBox.Text = "";
            this.phoneTextBox.Text = "";
            this.passwordTextBox.Text = "";
            this.maleRadio.Checked = true;
            this.addressTextBox.Text = "";
            this.salaryTextBox.Text = "";
        }
        private void initEditUser()
        {
            this.resetValidation();
            this.isEditStaff = true;
            this.submitButton.Text = "Cập nhật";
            this.gunaLabel3.Text = $"Chỉnh sửa thông tin nhân sự: {this.staff.staff_id}";
            this.deleteButton.Show();

            this.fullnameTextBox.Text = this.staff.fullname;
            this.phoneTextBox.Text = this.staff.phone;
            this.passwordTextBox.Text = this.staff.password;
            this.birthdatePicker.Value = this.staff.birthdate.Date;
            this.maleRadio.Checked = this.staff.gender == "Nam";
            this.famaleRadio.Checked = this.staff.gender == "Nữ";
            this.addressTextBox.Text = this.staff.address.ToString();
            this.salaryTextBox.Text = this.staff.salary.ToString();
            this.roleComboBox.SelectedIndex = this.staff.is_reception ? 0 : 1;
        }

        private void resetValidation()
        {
            this.fullnameEL.Hide();
            this.passwordEL.Hide();
            this.phoneEL.Hide();
            this.salaryEL.Hide();
        }

        private void staffsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIndex = this.staffsTable.CurrentCell.RowIndex;
            if (currentIndex < 0) return;
            DataGridViewRow row = this.staffsTable.Rows[currentIndex];
            this.staff = new StaffEntity()
            {
                staff_id = Int32.Parse(row.Cells["ID"].Value.ToString()),
                fullname = row.Cells["Họ Và Tên"].Value.ToString(),
                phone = row.Cells["Điện Thoại"].Value.ToString(),
                birthdate = DateTime.Parse(row.Cells["Ngày Sinh"].Value.ToString()),
                address = row.Cells["Địa Chỉ"].Value.ToString(),
                salary = int.Parse(row.Cells["Lương"].Value.ToString()),
                gender = row.Cells["Giới Tính"].Value.ToString(),
                password = row.Cells["Mật khẩu"].Value.ToString()
            };
            initEditUser();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.LoadStaffTableData();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            this.phoneTextBox_Leave(null, null);
            if (!ValidateChildren(ValidationConstraints.Enabled))
                return;
            
            StaffDB DB = new StaffDB();
            StaffEntity newStaff = new StaffEntity()
            {
                fullname = this.fullnameTextBox.Text,
                phone = this.phoneTextBox.Text,
                password = this.passwordTextBox.Text,
                birthdate = this.birthdatePicker.Value,
                address = this.addressTextBox.Text,
                salary = Int64.Parse(this.salaryTextBox.Text),
                gender = this.maleRadio.Checked ? "Nam" : "Nữ",
                is_reception = this.roleComboBox.SelectedIndex == 0,
                is_labor = this.roleComboBox.SelectedIndex == 1,
            };

            if (this.isEditStaff)
            {
                if (DB.update(this.staff.staff_id, newStaff))
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
            } else
            {
                if (DB.create(newStaff))
                {
                    MessageBox.Show("Tạo nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.LoadStaffTableData();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Bạn có chắc muốn xóa [{this.staff.fullname}]?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            StaffDB db = new StaffDB();
            new Thread(() =>
            {
                db.delete(this.staff.staff_id);
                this.LoadStaffTableData();
                this.initCreateUser();
            }).Start();
        }

        private void phoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.phoneTextBox, this.phoneEL);
            if (string.IsNullOrEmpty(this.phoneTextBox.Text))
            {
                vali.error("Vui lòng nhập ô này!");
                return;
            }
            if (!Validation.IsPhoneNumber(this.phoneTextBox.Text))
            {
                vali.error("SĐT không hợp lệ!");
                return;
            }
            vali.normal();
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress vali = new ValidateKeyPress(sender, e);
            vali.justAllowNumber();
        }

        private void clearProductButton_Click(object sender, EventArgs e)
        {
            this.initCreateUser();
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.passwordTextBox, this.passwordEL);
            string text = this.passwordTextBox.Text;
            if (string.IsNullOrEmpty(text))
            {
                vali.error("Vui lòng nhập ô này!");
                return;
            };
            if (text.Length < 5)
            {
                vali.error("Quá ngắn");
                return;
            }
            vali.normal();
        }

        private void fullnameTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.fullnameTextBox, this.fullnameEL);
            string text = this.fullnameTextBox.Text;
            if (string.IsNullOrEmpty(text))
            {
                vali.error("Vui lòng nhập ô này!");
                return;
            };
            vali.normal();
        }

        private void salaryTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.salaryTextBox, this.salaryEL);
            string text = this.salaryTextBox.Text;
            if (string.IsNullOrEmpty(text))
            {
                vali.error("Vui lòng nhập ô này!");
                return;
            };
            vali.normal();
        }

        private void salaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress vali = new ValidateKeyPress(sender, e);
            vali.justAllowNumber();
        }

        private void fullnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress vali = new ValidateKeyPress(sender, e);
            vali.justAllowAlphabet();
        }

        private void phoneTextBox_Leave(object sender, EventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(null, this.phoneTextBox, this.phoneEL);
            StaffDB db = new StaffDB();
            if (db.isExistedPhone(this.phoneTextBox.Text) && !this.isEditStaff)
            {
                vali.error("Số điện thoại đã tồn tại!");
                return;
            }
            vali.normal();
        }
    }
}

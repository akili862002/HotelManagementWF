using Hotel.Databases;
using Hotel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class ManagersForm : Form
    {
        public ManagersForm()
        {
            InitializeComponent();
        }
        ManagerEntity manage = null;
        bool isEditManager;
        private void ManagersForm_Load(object sender, EventArgs e)
        {
            this.initCreateManage();
            this.LoadManageTableData();
            birthdatePicker.Format = DateTimePickerFormat.Custom;
            birthdatePicker.CustomFormat = "MM/dd/yyyy";
        }
        private void resetValidation()
        {
            this.fullnameEL.Hide();
            this.passwordEL.Hide();
            this.phoneEL.Hide();
            this.salaryEL.Hide();
        }
        private void initCreateManage()
        {
            this.resetValidation();
            this.isEditManager = false;
            this.submitButton.Text = "Thêm";
            this.gunaLabel3.Text = $"Thêm quản lí";
            this.deleteButton.Show();

            this.fullnameTextBox.Text = "";
            this.phoneTextBox.Text = "";
            this.passwordTextBox.Text = "";
            this.maleRadio.Checked = true;
            this.addressTextBox.Text = "";
            this.salaryTextBox.Text = "";
        }
        public void LoadManageTableData()
        {
            ManagerDB db = new ManagerDB();
            new Thread(() =>
            {
                DataTable dt = new DataTable();
                db.getAllAdapter(
                        @"
                            manager_id as [ID], 
                            fullname as [Họ Và Tên],
                            phone as [Điện Thoại],
                            [password] as [Mật khẩu],
                            birthdate as [Ngày Sinh],
                            gender as [Giới Tính],
                            address as [Địa Chỉ],
                            salary as [Lương],
                            created_at as [Ngày nhận chức]
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
                this.gunaLabel6.Text = $"Danh sách Quản lí ({totalCount})";
            }).Start();
        }

        private void ManagersForm_Load_1(object sender, EventArgs e)
        {
            this.LoadManageTableData();
            this.initCreateManage();
            birthdatePicker.Format = DateTimePickerFormat.Custom;
            birthdatePicker.CustomFormat = "MM/dd/yyyy";

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.LoadManageTableData();
        }

        private void phoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.phoneTextBox, this.phoneEL);
            vali.required().isPhone();
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
            TextBoxValidation vali = new TextBoxValidation(e, this.addressTextBox, this.fullnameEL);
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
            vali.required();
        }

        private void clearProductButton_Click(object sender, EventArgs e)
        {
            this.initCreateManage();
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress vali = new ValidateKeyPress(sender, e);
            vali.justAllowNumber();
        }

        private void phoneTextBox_Leave(object sender, EventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(null, this.phoneTextBox, this.phoneEL);
            StaffDB db = new StaffDB();
            if (db.isExistedPhone(this.phoneTextBox.Text) && !this.isEditManager)
            {
                vali.error("Số điện thoại đã tồn tại!");
                return;
            }
            vali.normal();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Bạn có chắc muốn xóa quản lí [{this.manage.fullname}]?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            ManagerDB db = new ManagerDB();
            new Thread(() =>
            {
                db.delete(this.manage.manager_id);
                this.LoadManageTableData();
                this.initCreateManage();
            }).Start();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            this.phoneTextBox_Leave(null, null);
            if (!ValidateChildren(ValidationConstraints.Enabled))
                return;

            ManagerDB DB = new ManagerDB();
            ManagerEntity newManage = new ManagerEntity()
            {
                fullname = this.fullnameTextBox.Text,
                phone = this.phoneTextBox.Text,
                password = this.passwordTextBox.Text,
                birthdate = this.birthdatePicker.Value,
                address = this.addressTextBox.Text,
                salary = Int64.Parse(this.salaryTextBox.Text),
                gender = this.maleRadio.Checked ? "Nam" : "Nữ"
            };

            if (this.isEditManager)
            {
                if (DB.update(this.manage.manager_id, newManage))
                {
                    MessageBox.Show("Cập nhật quản lí thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
            }
            else
            {
                if (DB.create(newManage))
                {
                    MessageBox.Show("Tạo quản lí thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.LoadManageTableData();
        }
        private void initEditManage()
        {
            this.resetValidation();
            this.isEditManager = true;
            this.submitButton.Text = "Cập nhật";
            this.gunaLabel3.Text = $"Chỉnh sửa thông tin quản lí: {this.manage.manager_id}";
            this.deleteButton.Show();

            this.fullnameTextBox.Text = this.manage.fullname;
            this.phoneTextBox.Text = this.manage.phone;
            this.passwordTextBox.Text = this.manage.password;
            this.birthdatePicker.Value = this.manage.birthdate.Date;
            this.maleRadio.Checked = this.manage.gender == "Nam";
            this.famaleRadio.Checked = this.manage.gender == "Nữ";
            this.addressTextBox.Text = this.manage.address.ToString();
            this.salaryTextBox.Text = this.manage.salary.ToString();
        }
        private void staffsTable_Click(object sender, EventArgs e)
        {
            int currentIndex = this.staffsTable.CurrentCell.RowIndex;
            if (currentIndex < 0) return;
            DataGridViewRow row = this.staffsTable.Rows[currentIndex];
            this.manage = new ManagerEntity()
            {
                manager_id = Int32.Parse(row.Cells["ID"].Value.ToString()),
                fullname = row.Cells["Họ Và Tên"].Value.ToString(),
                phone = row.Cells["Điện Thoại"].Value.ToString(),
                birthdate = DateTime.Parse(row.Cells["Ngày Sinh"].Value.ToString()),
                address = row.Cells["Địa Chỉ"].Value.ToString(),
                salary = int.Parse(row.Cells["Lương"].Value.ToString()),
                gender = row.Cells["Giới Tính"].Value.ToString(),
                password = row.Cells["Mật khẩu"].Value.ToString()
            };
            initEditManage();
        }
    }
}

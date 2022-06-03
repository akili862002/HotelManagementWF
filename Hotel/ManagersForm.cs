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
            this.LoadStaffTableData();
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
        public void LoadStaffTableData()
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
            this.LoadStaffTableData();
            this.initCreateManage();
            birthdatePicker.Format = DateTimePickerFormat.Custom;
            birthdatePicker.CustomFormat = "MM/dd/yyyy";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.LoadStaffTableData();
        }
    }
}

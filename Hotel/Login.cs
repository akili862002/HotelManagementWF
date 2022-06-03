using Hotel.Databases;
using Hotel.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Login : Form
    {
        public object AdminEnity { get; private set; }
        public object ManagerEntity { get; private set; }

        public Login()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.init();
        }

        public void init()
        {
            this.phoneEL.Hide();
            this.passwordEL.Hide();
        }

        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.showPasswordCheckbox.Checked)
            {
                this.passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                this.passwordTextBox.PasswordChar = '•';
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
                return;

            try
            {
                string phone = this.phoneTextBox.Text;
                string password = this.passwordTextBox.Text;

                if (this.adminRadio.Checked)
                {
                    AdminDB db = new AdminDB();
                    AdminEntity admin = db.login(phone, password);
                    if (admin == null) throw new Exception();
                    // Success
                    Program.Global.admin = admin;
                    Program.Global.isAuth = true;
                }
                else if (this.managerRadio.Checked)
                {
                    ManagerDB db = new ManagerDB();
                    ManagerEntity manager = new ManagerEntity();
                    if (manager == null) throw new Exception();
                    // Success
                    Program.Global.manager = manager;
                    Program.Global.isAuth = true;
                }
                else if (this.receptionRadio.Checked)
                {
                    StaffDB db = new StaffDB();
                    StaffEntity staff = db.login(phone, password);
                    if (staff == null) throw new Exception();
                    // Success
                    Program.Global.staff = staff;
                    Program.Global.isAuth = true;
                }

                if (Program.Global.isAuth)
                {
                    // Hanlde login success!
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPress vali = new ValidateKeyPress(sender, e);
            vali.justAllowNumber();
        }

        private void phoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.phoneTextBox, this.phoneEL);
            vali.isPhone().required();
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBoxValidation vali = new TextBoxValidation(e, this.passwordTextBox, this.passwordEL);
            vali.minLength(6).required();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

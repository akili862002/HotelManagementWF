using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class NavigationForm : Form
    {
        public NavigationForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon1;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}

using Hotel.Databases;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.welcomeUserLabel.Text = $"Xin chào";
        }

        private void tablesButton_Click(object sender, EventArgs e)
        {
            using (RoomsForm roomForm = new RoomsForm())
            {
                roomForm.ShowDialog();
                this.loadData();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void menusButton_Click(object sender, EventArgs e)
        {
            using (MenusForm menuForm = new MenusForm())
            {
                menuForm.ShowDialog();
                this.loadData();
            }
        }

        private void staffManagerButton_Click(object sender, EventArgs e)
        {
            using (StaffsForm staffForm = new StaffsForm())
            {
                staffForm.ShowDialog();
                this.loadData();
            }
        }

        private void statisticButton_Click(object sender, EventArgs e)
        {
            using (StatisticForm statisticForm = new StatisticForm())
            {
                statisticForm.ShowDialog();
                this.loadData();
            }
        }
        BookingDB order = new BookingDB();
        ManagerDB user = new ManagerDB();

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void loadData()
        {
            return;
            orderTodayLabel.Text = order.getCountOder().ToString();
            revenueTodayLabel.Text = order.getCountRevenue().ToString();
            totalStaffLabel.Text = user.countUser().ToString();
        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            using (ManagersForm managersForm = new ManagersForm())
            {
                managersForm.ShowDialog();
            }
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            using (CustomersForm fm = new CustomersForm())
            {
                fm.ShowDialog();
            }
        }
    }
}

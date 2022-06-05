using Hotel.Databases;
using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.welcomeUserLabel.Text = $"Xin chào";

            if (Program.Global.staff != null)
            {
                this.staffManagerButton.Enabled = false;
                this.managerButton.Enabled = false;
            } else 
            if (Program.Global.manager != null){
                this.managerButton.Enabled = false;
            } else
            {
                this.staffManagerButton.Enabled = true;
                this.managerButton.Enabled = true;
            }
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
            Program.Global.staff = null;
            Program.Global.manager = null;
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
        StaffDB user = new StaffDB();

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.loadData();
            orderTodayLabel.Text = room.countRoom().ToString();
            revenueTodayLabel.Text = order.getCountRevenue().ToString();
            totalStaffLabel.Text = (staff.countUser()+ user.countUser()).ToString();
        }

        private void loadData()
        {
            try
            {
                orderTodayLabel.Text = order.getCountOder().ToString();
                revenueTodayLabel.Text = Currency.formatPrice(long.Parse(order.getCountRevenue().ToString()));
                totalStaffLabel.Text = user.countUser().ToString();
            } catch
            {

            }
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

        private void statisticButton_Click_1(object sender, EventArgs e)
        {
            using (StatisticForm fm = new StatisticForm())
            {
                fm.ShowDialog();
            }
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            using (ScheduleForm fm = new ScheduleForm())
            {
                fm.ShowDialog();
            }
        }
    }
}

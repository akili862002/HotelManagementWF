using Hotel.Databases;
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
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }
        public void LoadCustomerTableData()
        {
            CustomerDB db = new CustomerDB();
            new Thread(() =>
            {
                DataTable dt = new DataTable();
                db.getAllAdapter(
                        @"
                            customer_id as [ID], 
                            fullname as [Họ Và Tên],
                            phone as [Điện Thoại],
                            id_card as [Card ID],
                            created_at as [Ngày Thuê]
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
                this.gunaLabel6.Text = $"Danh sách Khách hàng  ({totalCount})";
            }).Start();
        }
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            this.LoadCustomerTableData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.LoadCustomerTableData();
        }
    }
}

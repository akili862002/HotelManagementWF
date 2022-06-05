using Hotel.Databases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();

            this.loadProductChart();
            //this.loadStaffChart();
            this.loadOrderTable();

            this.orderToDatePicker.Value = DateTime.Now;
            FormatDatePicker.format(this.orderFromDatePicker);
            FormatDatePicker.format(this.orderToDatePicker);
        }

        private void orderFilterCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.orderFilterPanel.Enabled = this.orderFilterCheckbox.Checked;
        }

        private void loadProductChart()
        {
            ProductDB db = new ProductDB();
            DataTable dt = new DataTable();
            db.getStatisticsAdapter().Fill(dt);
            this.productChart.DataSource = dt;
            this.productChart.Series["Benefit"].YValueMembers = "Total price";
            this.productChart.Series["Benefit"].XValueMember = "name";
        }

        private void loadStaffChart()
        {
            ManagerDB db = new ManagerDB();
            DataTable dt = new DataTable();
            db.getStatisticsAdapter().Fill(dt);
            this.staffChart.DataSource = dt;
            this.staffChart.Series["Order"].YValueMembers = "amount";
            this.staffChart.Series["Order"].XValueMember = "fullname";
        }

        private void loadOrderTable()
        {
            BookingDB db = new BookingDB();
            DataTable dt = new DataTable();
            db.getAllOrdersAdapter(
                @"
                    [order_item].order_item_id as [Mã đơn],
                    DATEDIFF(hour, booking.created_at, booking.expire_at)*room.price_per_hour AS [Tổng tiền],
                    CASE WHEN bill.booking_id IS NULL THEN N'Chưa tính tiền' ELSE N'Đã thanh toán' END AS [Tình trạng], 
                    [order_item].created_at as [thoi gian thuê]

                "
                ).Fill(dt);
            this.orderTable.DataSource = dt;
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
        }

        private void filterStaffButton_Click(object sender, EventArgs e)
        {

        }

        private void filterProductButton_Click(object sender, EventArgs e)
        {
            this.loadProductChart();
        }

        
    }
}

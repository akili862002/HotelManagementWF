using Hotel.Databases;
using Hotel.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Checkout : Form
    {
        BookingEntity booking;
        long totalPrice;
        long pricePerHours;

        public Checkout(int booking_id, string roomName, long pricePerHours)
        {
            InitializeComponent();

            BookingDB db = new BookingDB();
            booking = db.getById(booking_id);

            this.titleLablel.Text = $"Thanh toán {roomName}";
            this.orderLabel.Text = $"Mã thuê #{booking.booking_id}";
            this.fromDateLabel.Text = booking.created_at.ToString();
            this.toDateLabel.Text = booking.expire_at.ToString();
            this.barcode.Text = booking.booking_id.ToString();

            double totalSec = (booking.expire_at - booking.created_at).TotalMinutes;
            this.totalPrice = (long)Math.Round(pricePerHours / 60 * totalSec);
            this.totalPriceLabel.Text = Currency.formatPrice(this.totalPrice);
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            BillDB db = new BillDB();
            BillEntity bill = new BillEntity() { 
                booking_id = this.booking.booking_id,
                desc = this.descTextBox.Text,
                total_price = this.totalPrice 
            } ;
            if (db.create(bill))
            {
                MessageBox.Show("Thanh toán thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            };
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog.Show();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.billPanel.Width, this.billPanel.Height);
            this.billPanel.DrawToBitmap(bm, new Rectangle(0, 0, this.billPanel.Width, this.billPanel.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}

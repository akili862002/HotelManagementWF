using QRCoder;
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
    public partial class QRCodeForm : Form
    {
        string code;
        public QRCodeForm(string code, string title, string desc)
        {
            InitializeComponent();
            this.code = code;

            QRCodeGenerator generator = new QRCodeGenerator();
            var qr = generator.CreateQrCode(this.code, QRCodeGenerator.ECCLevel.H);
            var c = new QRCode(qr);
            this.qrPic.Image = c.GetGraphic(50);
            this.titlePanel.Text = title;
            this.descPanel.Text = desc;
        }

        private void QRCodeForm_Load(object sender, EventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog.Show();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.panel.Width, this.panel.Height);
            this.panel.DrawToBitmap(bm, new Rectangle(0, 0, this.panel.Width, this.panel.Height));
            e.Graphics.DrawImage(bm, 0, 0);

        }
    }
}

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
        public QRCodeForm(string code)
        {
            InitializeComponent();
            this.code = code;

            QRCodeGenerator generator = new QRCodeGenerator();
            var qr = generator.CreateQrCode(this.code, QRCodeGenerator.ECCLevel.H);
            var c = new QRCode(qr);
            this.qrPic.Image = c.GetGraphic(50);
        }
    }
}

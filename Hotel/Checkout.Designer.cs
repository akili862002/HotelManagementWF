
namespace Hotel
{
    partial class Checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator3 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this.titleLablel = new Guna.UI.WinForms.GunaLabel();
            this.descTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel18 = new Guna.UI.WinForms.GunaLabel();
            this.checkoutButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.totalPriceLabel = new Guna.UI.WinForms.GunaLabel();
            this.orderLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.fromDateLabel = new Guna.UI.WinForms.GunaLabel();
            this.toDateLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.barcode = new DevExpress.XtraEditors.BarCodeControl();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.billPanel = new Guna.UI.WinForms.GunaPanel();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.billPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLablel
            // 
            this.titleLablel.AutoSize = true;
            this.titleLablel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLablel.Location = new System.Drawing.Point(2, 2);
            this.titleLablel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLablel.Name = "titleLablel";
            this.titleLablel.Size = new System.Drawing.Size(162, 37);
            this.titleLablel.TabIndex = 5;
            this.titleLablel.Text = "Thanh toán";
            // 
            // descTextBox
            // 
            this.descTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descTextBox.BackColor = System.Drawing.Color.Transparent;
            this.descTextBox.BaseColor = System.Drawing.Color.White;
            this.descTextBox.BorderColor = System.Drawing.Color.Silver;
            this.descTextBox.BorderSize = 1;
            this.descTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.descTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.descTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.descTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descTextBox.Location = new System.Drawing.Point(8, 331);
            this.descTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.descTextBox.Multiline = true;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.descTextBox.PasswordChar = '\0';
            this.descTextBox.Radius = 4;
            this.descTextBox.SelectedText = "";
            this.descTextBox.Size = new System.Drawing.Size(473, 86);
            this.descTextBox.TabIndex = 104;
            // 
            // gunaLabel18
            // 
            this.gunaLabel18.AutoSize = true;
            this.gunaLabel18.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel18.Location = new System.Drawing.Point(5, 308);
            this.gunaLabel18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(58, 19);
            this.gunaLabel18.TabIndex = 105;
            this.gunaLabel18.Text = "Ghi chú";
            // 
            // checkoutButton
            // 
            this.checkoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkoutButton.Animated = true;
            this.checkoutButton.AnimationHoverSpeed = 0.07F;
            this.checkoutButton.AnimationSpeed = 0.03F;
            this.checkoutButton.BackColor = System.Drawing.Color.Transparent;
            this.checkoutButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkoutButton.BorderColor = System.Drawing.Color.Black;
            this.checkoutButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.checkoutButton.FocusedColor = System.Drawing.Color.Empty;
            this.checkoutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.ForeColor = System.Drawing.Color.White;
            this.checkoutButton.Image = null;
            this.checkoutButton.ImageSize = new System.Drawing.Size(20, 20);
            this.checkoutButton.Location = new System.Drawing.Point(325, 426);
            this.checkoutButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.checkoutButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.checkoutButton.OnHoverForeColor = System.Drawing.Color.White;
            this.checkoutButton.OnHoverImage = null;
            this.checkoutButton.OnPressedColor = System.Drawing.Color.Black;
            this.checkoutButton.Radius = 4;
            this.checkoutButton.Size = new System.Drawing.Size(153, 40);
            this.checkoutButton.TabIndex = 106;
            this.checkoutButton.Text = "Thanh toán";
            this.checkoutButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(171, 239);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(139, 32);
            this.gunaLabel3.TabIndex = 109;
            this.gunaLabel3.Text = "Tổng tiền: ";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.totalPriceLabel.Location = new System.Drawing.Point(304, 240);
            this.totalPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(161, 31);
            this.totalPriceLabel.TabIndex = 110;
            this.totalPriceLabel.Text = "0đ";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.Location = new System.Drawing.Point(8, 45);
            this.orderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(78, 30);
            this.orderLabel.TabIndex = 111;
            this.orderLabel.Text = "Phòng";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(14, 84);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(74, 19);
            this.gunaLabel1.TabIndex = 112;
            this.gunaLabel1.Text = "Ngày thuê";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(14, 103);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(102, 19);
            this.gunaLabel2.TabIndex = 113;
            this.gunaLabel2.Text = "Thuê đến ngày";
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateLabel.Location = new System.Drawing.Point(167, 84);
            this.fromDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(74, 17);
            this.fromDateLabel.TabIndex = 115;
            this.fromDateLabel.Text = "10/10/2010";
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateLabel.Location = new System.Drawing.Point(167, 105);
            this.toDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(74, 17);
            this.toDateLabel.TabIndex = 116;
            this.toDateLabel.Text = "10/10/2010";
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton1.Animated = true;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(221, 426);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 4;
            this.gunaButton1.Size = new System.Drawing.Size(100, 40);
            this.gunaButton1.TabIndex = 118;
            this.gunaButton1.Text = "In hóa đơn";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(15, 142);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(98, 19);
            this.gunaLabel6.TabIndex = 121;
            this.gunaLabel6.Text = "Mã đặt phòng";
            // 
            // barcode
            // 
            this.barcode.Location = new System.Drawing.Point(13, 164);
            this.barcode.Name = "barcode";
            this.barcode.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barcode.Size = new System.Drawing.Size(242, 57);
            this.barcode.Symbology = code128Generator3;
            this.barcode.TabIndex = 122;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(14, 124);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(49, 19);
            this.gunaLabel5.TabIndex = 123;
            this.gunaLabel5.Text = "Phòng";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(173, 124);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(75, 19);
            this.gunaLabel7.TabIndex = 124;
            this.gunaLabel7.Text = "Phòng 123";
            // 
            // billPanel
            // 
            this.billPanel.Controls.Add(this.titleLablel);
            this.billPanel.Controls.Add(this.gunaLabel7);
            this.billPanel.Controls.Add(this.gunaLabel3);
            this.billPanel.Controls.Add(this.orderLabel);
            this.billPanel.Controls.Add(this.totalPriceLabel);
            this.billPanel.Controls.Add(this.gunaLabel5);
            this.billPanel.Controls.Add(this.gunaLabel1);
            this.billPanel.Controls.Add(this.barcode);
            this.billPanel.Controls.Add(this.gunaLabel2);
            this.billPanel.Controls.Add(this.gunaLabel6);
            this.billPanel.Controls.Add(this.fromDateLabel);
            this.billPanel.Controls.Add(this.toDateLabel);
            this.billPanel.Location = new System.Drawing.Point(9, 12);
            this.billPanel.Name = "billPanel";
            this.billPanel.Size = new System.Drawing.Size(472, 284);
            this.billPanel.TabIndex = 125;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 476);
            this.Controls.Add(this.billPanel);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.gunaLabel18);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.billPanel.ResumeLayout(false);
            this.billPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel titleLablel;
        private Guna.UI.WinForms.GunaTextBox descTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaButton checkoutButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel totalPriceLabel;
        private Guna.UI.WinForms.GunaLabel orderLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel fromDateLabel;
        private Guna.UI.WinForms.GunaLabel toDateLabel;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private DevExpress.XtraEditors.BarCodeControl barcode;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaPanel billPanel;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}
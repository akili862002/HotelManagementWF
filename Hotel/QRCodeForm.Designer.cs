
namespace Hotel
{
    partial class QRCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCodeForm));
            this.qrPic = new Guna.UI.WinForms.GunaPictureBox();
            this.printButton = new Guna.UI.WinForms.GunaButton();
            this.titlePanel = new Guna.UI.WinForms.GunaLabel();
            this.panel = new Guna.UI.WinForms.GunaPanel();
            this.descPanel = new Guna.UI.WinForms.GunaLabel();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.qrPic)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // qrPic
            // 
            this.qrPic.BaseColor = System.Drawing.Color.White;
            this.qrPic.Location = new System.Drawing.Point(67, 97);
            this.qrPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qrPic.Name = "qrPic";
            this.qrPic.Size = new System.Drawing.Size(333, 325);
            this.qrPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrPic.TabIndex = 0;
            this.qrPic.TabStop = false;
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.Animated = true;
            this.printButton.AnimationHoverSpeed = 0.07F;
            this.printButton.AnimationSpeed = 0.03F;
            this.printButton.BackColor = System.Drawing.Color.Transparent;
            this.printButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.printButton.BorderColor = System.Drawing.Color.Black;
            this.printButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.printButton.FocusedColor = System.Drawing.Color.Empty;
            this.printButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Image = null;
            this.printButton.ImageSize = new System.Drawing.Size(20, 20);
            this.printButton.Location = new System.Drawing.Point(75, 471);
            this.printButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.printButton.Name = "printButton";
            this.printButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.printButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.printButton.OnHoverForeColor = System.Drawing.Color.White;
            this.printButton.OnHoverImage = null;
            this.printButton.OnPressedColor = System.Drawing.Color.Black;
            this.printButton.Radius = 4;
            this.printButton.Size = new System.Drawing.Size(333, 32);
            this.printButton.TabIndex = 5;
            this.printButton.Text = "In QR code";
            this.printButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.AutoSize = true;
            this.titlePanel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePanel.Location = new System.Drawing.Point(68, 15);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(99, 30);
            this.titlePanel.TabIndex = 22;
            this.titlePanel.Text = "QR Code";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.descPanel);
            this.panel.Controls.Add(this.titlePanel);
            this.panel.Controls.Add(this.qrPic);
            this.panel.Location = new System.Drawing.Point(8, 8);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(460, 447);
            this.panel.TabIndex = 23;
            // 
            // descPanel
            // 
            this.descPanel.AutoSize = true;
            this.descPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descPanel.Location = new System.Drawing.Point(69, 54);
            this.descPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descPanel.Name = "descPanel";
            this.descPanel.Size = new System.Drawing.Size(75, 21);
            this.descPanel.TabIndex = 57;
            this.descPanel.Text = "Nội dung";
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
            // QRCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(475, 526);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.printButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QRCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QRCode";
            this.Load += new System.EventHandler(this.QRCodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrPic)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox qrPic;
        private Guna.UI.WinForms.GunaButton printButton;
        private Guna.UI.WinForms.GunaLabel titlePanel;
        private Guna.UI.WinForms.GunaPanel panel;
        private Guna.UI.WinForms.GunaLabel descPanel;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}
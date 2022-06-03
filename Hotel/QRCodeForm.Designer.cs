
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
            this.qrPic = new Guna.UI.WinForms.GunaPictureBox();
            this.loginButton = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.qrPic)).BeginInit();
            this.SuspendLayout();
            // 
            // qrPic
            // 
            this.qrPic.BaseColor = System.Drawing.Color.White;
            this.qrPic.Location = new System.Drawing.Point(107, 46);
            this.qrPic.Name = "qrPic";
            this.qrPic.Size = new System.Drawing.Size(500, 500);
            this.qrPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrPic.TabIndex = 0;
            this.qrPic.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.Animated = true;
            this.loginButton.AnimationHoverSpeed = 0.07F;
            this.loginButton.AnimationSpeed = 0.03F;
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.loginButton.BorderColor = System.Drawing.Color.Black;
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginButton.FocusedColor = System.Drawing.Color.Empty;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Image = null;
            this.loginButton.ImageSize = new System.Drawing.Size(20, 20);
            this.loginButton.Location = new System.Drawing.Point(107, 591);
            this.loginButton.Name = "loginButton";
            this.loginButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.loginButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.loginButton.OnHoverImage = null;
            this.loginButton.OnPressedColor = System.Drawing.Color.Black;
            this.loginButton.Radius = 4;
            this.loginButton.Size = new System.Drawing.Size(500, 50);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "In QR code";
            this.loginButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QRCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 668);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.qrPic);
            this.Name = "QRCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QRCode";
            ((System.ComponentModel.ISupportInitialize)(this.qrPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox qrPic;
        private Guna.UI.WinForms.GunaButton loginButton;
    }
}
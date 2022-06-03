
namespace Hotel
{
    partial class NavigationForm
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.roomKeyButton = new Guna.UI.WinForms.GunaTileButton();
            this.attendanceButton = new Guna.UI.WinForms.GunaTileButton();
            this.loginButton = new Guna.UI.WinForms.GunaTileButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(489, 91);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(736, 156);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Chào mừng tới phần mềm quản lý khách sạn";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel2.Location = new System.Drawing.Point(327, 340);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(736, 76);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Chọn trang bạn muốn tới";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomKeyButton
            // 
            this.roomKeyButton.Animated = true;
            this.roomKeyButton.AnimationHoverSpeed = 0.07F;
            this.roomKeyButton.AnimationSpeed = 0.03F;
            this.roomKeyButton.BackColor = System.Drawing.Color.Transparent;
            this.roomKeyButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.roomKeyButton.BorderColor = System.Drawing.Color.Black;
            this.roomKeyButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.roomKeyButton.FocusedColor = System.Drawing.Color.Empty;
            this.roomKeyButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomKeyButton.ForeColor = System.Drawing.Color.White;
            this.roomKeyButton.Image = global::Hotel.Properties.Resources.room_key;
            this.roomKeyButton.ImageSize = new System.Drawing.Size(52, 52);
            this.roomKeyButton.Location = new System.Drawing.Point(922, 515);
            this.roomKeyButton.Name = "roomKeyButton";
            this.roomKeyButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.roomKeyButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.roomKeyButton.OnHoverForeColor = System.Drawing.Color.White;
            this.roomKeyButton.OnHoverImage = null;
            this.roomKeyButton.OnPressedColor = System.Drawing.Color.Black;
            this.roomKeyButton.Radius = 4;
            this.roomKeyButton.Size = new System.Drawing.Size(422, 210);
            this.roomKeyButton.TabIndex = 17;
            this.roomKeyButton.Text = "Khóa phòng";
            // 
            // attendanceButton
            // 
            this.attendanceButton.Animated = true;
            this.attendanceButton.AnimationHoverSpeed = 0.07F;
            this.attendanceButton.AnimationSpeed = 0.03F;
            this.attendanceButton.BackColor = System.Drawing.Color.Transparent;
            this.attendanceButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.attendanceButton.BorderColor = System.Drawing.Color.Black;
            this.attendanceButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.attendanceButton.FocusedColor = System.Drawing.Color.Empty;
            this.attendanceButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceButton.ForeColor = System.Drawing.Color.White;
            this.attendanceButton.Image = global::Hotel.Properties.Resources.qr;
            this.attendanceButton.ImageSize = new System.Drawing.Size(52, 52);
            this.attendanceButton.Location = new System.Drawing.Point(476, 515);
            this.attendanceButton.Name = "attendanceButton";
            this.attendanceButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.attendanceButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.attendanceButton.OnHoverForeColor = System.Drawing.Color.White;
            this.attendanceButton.OnHoverImage = null;
            this.attendanceButton.OnPressedColor = System.Drawing.Color.Black;
            this.attendanceButton.Radius = 4;
            this.attendanceButton.Size = new System.Drawing.Size(422, 210);
            this.attendanceButton.TabIndex = 16;
            this.attendanceButton.Text = "Điểm danh";
            // 
            // loginButton
            // 
            this.loginButton.Animated = true;
            this.loginButton.AnimationHoverSpeed = 0.07F;
            this.loginButton.AnimationSpeed = 0.03F;
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.loginButton.BorderColor = System.Drawing.Color.Black;
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginButton.FocusedColor = System.Drawing.Color.Empty;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Image = global::Hotel.Properties.Resources.hotel;
            this.loginButton.ImageSize = new System.Drawing.Size(52, 52);
            this.loginButton.Location = new System.Drawing.Point(27, 515);
            this.loginButton.Name = "loginButton";
            this.loginButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.loginButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.loginButton.OnHoverImage = null;
            this.loginButton.OnPressedColor = System.Drawing.Color.Black;
            this.loginButton.Radius = 4;
            this.loginButton.Size = new System.Drawing.Size(422, 210);
            this.loginButton.TabIndex = 15;
            this.loginButton.Text = "Quản lý khách sạn";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Hotel.Properties.Resources.logo4;
            this.gunaPictureBox1.Location = new System.Drawing.Point(59, -41);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(488, 436);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 6;
            this.gunaPictureBox1.TabStop = false;
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1365, 752);
            this.Controls.Add(this.roomKeyButton);
            this.Controls.Add(this.attendanceButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Name = "NavigationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navigation";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTileButton loginButton;
        private Guna.UI.WinForms.GunaTileButton attendanceButton;
        private Guna.UI.WinForms.GunaTileButton roomKeyButton;
    }
}
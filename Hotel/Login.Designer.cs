
namespace Hotel
{
    partial class Login
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
            this.loginButton = new Guna.UI.WinForms.GunaButton();
            this.phoneTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.passwordTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.showPasswordCheckbox = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.phoneEL = new Guna.UI.WinForms.GunaLabel();
            this.passwordEL = new Guna.UI.WinForms.GunaLabel();
            this.managerRadio = new Guna.UI.WinForms.GunaRadioButton();
            this.receptionRadio = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.adminRadio = new Guna.UI.WinForms.GunaRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.loginButton.Location = new System.Drawing.Point(468, 534);
            this.loginButton.Name = "loginButton";
            this.loginButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.loginButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.loginButton.OnHoverImage = null;
            this.loginButton.OnPressedColor = System.Drawing.Color.Black;
            this.loginButton.Radius = 4;
            this.loginButton.Size = new System.Drawing.Size(527, 50);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Đăng nhập";
            this.loginButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.BackColor = System.Drawing.Color.Transparent;
            this.phoneTextBox.BaseColor = System.Drawing.Color.White;
            this.phoneTextBox.BorderColor = System.Drawing.Color.Silver;
            this.phoneTextBox.BorderSize = 1;
            this.phoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.phoneTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.phoneTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneTextBox.Location = new System.Drawing.Point(467, 298);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.phoneTextBox.PasswordChar = '\0';
            this.phoneTextBox.Radius = 4;
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.Size = new System.Drawing.Size(528, 50);
            this.phoneTextBox.TabIndex = 1;
            this.phoneTextBox.Text = "0123456789";
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            this.phoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.phoneTextBox_Validating);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(463, 262);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(133, 28);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Số điện thoại";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(463, 374);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(98, 28);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Mật khẩu";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.BaseColor = System.Drawing.Color.White;
            this.passwordTextBox.BorderColor = System.Drawing.Color.Silver;
            this.passwordTextBox.BorderSize = 1;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.passwordTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.passwordTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTextBox.Location = new System.Drawing.Point(467, 406);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Radius = 4;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(528, 50);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Tag = "";
            this.passwordTextBox.Text = "123456";
            this.passwordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.passwordTextBox_Validating);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gunaLabel4.Location = new System.Drawing.Point(466, 152);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(333, 25);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "Xin chào, vui lòng đăng nhập để tiếp tục";
            // 
            // showPasswordCheckbox
            // 
            this.showPasswordCheckbox.BaseColor = System.Drawing.Color.White;
            this.showPasswordCheckbox.CheckedOffColor = System.Drawing.Color.Gray;
            this.showPasswordCheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.showPasswordCheckbox.FillColor = System.Drawing.Color.White;
            this.showPasswordCheckbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordCheckbox.Location = new System.Drawing.Point(468, 483);
            this.showPasswordCheckbox.Name = "showPasswordCheckbox";
            this.showPasswordCheckbox.Size = new System.Drawing.Size(195, 31);
            this.showPasswordCheckbox.TabIndex = 3;
            this.showPasswordCheckbox.Text = "Hiển thị mật khẩu";
            this.showPasswordCheckbox.CheckedChanged += new System.EventHandler(this.showPasswordCheckbox_CheckedChanged);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Hotel.Properties.Resources.logo4;
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 121);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(438, 488);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 3;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(455, 76);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(295, 70);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Đăng nhập";
            // 
            // phoneEL
            // 
            this.phoneEL.AutoSize = true;
            this.phoneEL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneEL.ForeColor = System.Drawing.Color.Red;
            this.phoneEL.Location = new System.Drawing.Point(466, 349);
            this.phoneEL.Name = "phoneEL";
            this.phoneEL.Size = new System.Drawing.Size(169, 25);
            this.phoneEL.TabIndex = 12;
            this.phoneEL.Text = "Error will be like this";
            // 
            // passwordEL
            // 
            this.passwordEL.AutoSize = true;
            this.passwordEL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordEL.ForeColor = System.Drawing.Color.Red;
            this.passwordEL.Location = new System.Drawing.Point(466, 459);
            this.passwordEL.Name = "passwordEL";
            this.passwordEL.Size = new System.Drawing.Size(169, 25);
            this.passwordEL.TabIndex = 13;
            this.passwordEL.Text = "Error will be like this";
            // 
            // managerRadio
            // 
            this.managerRadio.BaseColor = System.Drawing.SystemColors.Control;
            this.managerRadio.CheckedOffColor = System.Drawing.Color.Gray;
            this.managerRadio.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.managerRadio.FillColor = System.Drawing.Color.White;
            this.managerRadio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerRadio.Location = new System.Drawing.Point(648, 205);
            this.managerRadio.Name = "managerRadio";
            this.managerRadio.Size = new System.Drawing.Size(103, 31);
            this.managerRadio.TabIndex = 29;
            this.managerRadio.Text = "Quản lý";
            // 
            // receptionRadio
            // 
            this.receptionRadio.BaseColor = System.Drawing.SystemColors.Control;
            this.receptionRadio.Checked = true;
            this.receptionRadio.CheckedOffColor = System.Drawing.Color.Gray;
            this.receptionRadio.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.receptionRadio.FillColor = System.Drawing.Color.White;
            this.receptionRadio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receptionRadio.Location = new System.Drawing.Point(536, 205);
            this.receptionRadio.Name = "receptionRadio";
            this.receptionRadio.Size = new System.Drawing.Size(106, 31);
            this.receptionRadio.TabIndex = 28;
            this.receptionRadio.Text = "Tiếp tân";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(468, 205);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(59, 28);
            this.gunaLabel7.TabIndex = 30;
            this.gunaLabel7.Text = "Tôi là";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adminRadio
            // 
            this.adminRadio.BaseColor = System.Drawing.SystemColors.Control;
            this.adminRadio.CheckedOffColor = System.Drawing.Color.Gray;
            this.adminRadio.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.adminRadio.FillColor = System.Drawing.Color.White;
            this.adminRadio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRadio.Location = new System.Drawing.Point(766, 205);
            this.adminRadio.Name = "adminRadio";
            this.adminRadio.Size = new System.Drawing.Size(119, 31);
            this.adminRadio.TabIndex = 31;
            this.adminRadio.Text = "Giám đốc";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 712);
            this.Controls.Add(this.adminRadio);
            this.Controls.Add(this.managerRadio);
            this.Controls.Add(this.receptionRadio);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.passwordEL);
            this.Controls.Add(this.phoneEL);
            this.Controls.Add(this.showPasswordCheckbox);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.gunaPictureBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton loginButton;
        private Guna.UI.WinForms.GunaTextBox phoneTextBox;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox passwordTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaCheckBox showPasswordCheckbox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel phoneEL;
        private Guna.UI.WinForms.GunaLabel passwordEL;
        private Guna.UI.WinForms.GunaRadioButton managerRadio;
        private Guna.UI.WinForms.GunaRadioButton receptionRadio;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaRadioButton adminRadio;
    }
}


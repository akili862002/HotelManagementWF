
namespace Hotel
{
    partial class RoomsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsForm));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.tableListView = new System.Windows.Forms.ListView();
            this.currTableLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.totalPriceLabel = new Guna.UI.WinForms.GunaLabel();
            this.checkoutButton = new Guna.UI.WinForms.GunaButton();
            this.roomDescLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.fromDatePicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.toDatePicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.rentButton = new Guna.UI.WinForms.GunaButton();
            this.fromTimePicker = new DevExpress.XtraEditors.TimeEdit();
            this.toTimePicker = new DevExpress.XtraEditors.TimeEdit();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.phoneEL = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.phoneTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.fullnameEL = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.fullnameTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.idEL = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.idTexBox = new Guna.UI.WinForms.GunaTextBox();
            this.deleteButton = new Guna.UI.WinForms.GunaButton();
            this.takePicButton = new Guna.UI.WinForms.GunaButton();
            this.infoLockPanel = new Guna.UI.WinForms.GunaPanel();
            this.findPhoneButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.pricePerHoursLabel = new Guna.UI.WinForms.GunaLabel();
            this.showQRCodeButton = new Guna.UI.WinForms.GunaButton();
            this.picPicture = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fromTimePicker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toTimePicker.Properties)).BeginInit();
            this.infoLockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(8, 6);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(264, 47);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "Quản lý phòng";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.White;
            this.imageList.Images.SetKeyName(0, "empty.jpg");
            this.imageList.Images.SetKeyName(1, "using.jpg");
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(13, 77);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(62, 21);
            this.gunaLabel2.TabIndex = 37;
            this.gunaLabel2.Text = "Bàn ăn";
            // 
            // tableListView
            // 
            this.tableListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableListView.BackColor = System.Drawing.Color.White;
            this.tableListView.HideSelection = false;
            this.tableListView.LargeImageList = this.imageList;
            this.tableListView.Location = new System.Drawing.Point(16, 103);
            this.tableListView.Margin = new System.Windows.Forms.Padding(2);
            this.tableListView.Name = "tableListView";
            this.tableListView.Size = new System.Drawing.Size(453, 576);
            this.tableListView.TabIndex = 38;
            this.tableListView.UseCompatibleStateImageBehavior = false;
            this.tableListView.SelectedIndexChanged += new System.EventHandler(this.tableListView_SelectedIndexChanged);
            this.tableListView.Click += new System.EventHandler(this.tableListView_Click);
            // 
            // currTableLabel
            // 
            this.currTableLabel.AutoSize = true;
            this.currTableLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currTableLabel.Location = new System.Drawing.Point(488, 55);
            this.currTableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currTableLabel.Name = "currTableLabel";
            this.currTableLabel.Size = new System.Drawing.Size(284, 32);
            this.currTableLabel.TabIndex = 40;
            this.currTableLabel.Text = "Chọn phòng để tiếp tục";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(534, 647);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(139, 32);
            this.gunaLabel3.TabIndex = 42;
            this.gunaLabel3.Text = "Tổng tiền: ";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.totalPriceLabel.Location = new System.Drawing.Point(677, 647);
            this.totalPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(44, 32);
            this.totalPriceLabel.TabIndex = 43;
            this.totalPriceLabel.Text = "0đ";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.checkoutButton.Location = new System.Drawing.Point(866, 639);
            this.checkoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.checkoutButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.checkoutButton.OnHoverForeColor = System.Drawing.Color.White;
            this.checkoutButton.OnHoverImage = null;
            this.checkoutButton.OnPressedColor = System.Drawing.Color.Black;
            this.checkoutButton.Radius = 4;
            this.checkoutButton.Size = new System.Drawing.Size(124, 40);
            this.checkoutButton.TabIndex = 44;
            this.checkoutButton.Text = "Thanh toán";
            this.checkoutButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // roomDescLabel
            // 
            this.roomDescLabel.AutoSize = true;
            this.roomDescLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDescLabel.Location = new System.Drawing.Point(492, 88);
            this.roomDescLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomDescLabel.Name = "roomDescLabel";
            this.roomDescLabel.Size = new System.Drawing.Size(75, 21);
            this.roomDescLabel.TabIndex = 56;
            this.roomDescLabel.Text = "Nội dung";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(492, 142);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(123, 21);
            this.gunaLabel4.TabIndex = 56;
            this.gunaLabel4.Text = "Thông tin thuê";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.fromDatePicker.BaseColor = System.Drawing.Color.White;
            this.fromDatePicker.BorderColor = System.Drawing.Color.Silver;
            this.fromDatePicker.BorderSize = 1;
            this.fromDatePicker.CustomFormat = null;
            this.fromDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fromDatePicker.Enabled = false;
            this.fromDatePicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fromDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fromDatePicker.ForeColor = System.Drawing.Color.Black;
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDatePicker.Location = new System.Drawing.Point(501, 183);
            this.fromDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fromDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.fromDatePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fromDatePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fromDatePicker.OnPressedColor = System.Drawing.Color.Black;
            this.fromDatePicker.Radius = 4;
            this.fromDatePicker.Size = new System.Drawing.Size(336, 32);
            this.fromDatePicker.TabIndex = 123;
            this.fromDatePicker.Text = "5/17/2022";
            this.fromDatePicker.Value = new System.DateTime(2022, 5, 17, 14, 30, 22, 650);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(500, 162);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(74, 19);
            this.gunaLabel5.TabIndex = 124;
            this.gunaLabel5.Text = "Ngày thuê";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(502, 219);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(102, 19);
            this.gunaLabel7.TabIndex = 126;
            this.gunaLabel7.Text = "Thuê đến ngày";
            // 
            // toDatePicker
            // 
            this.toDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.toDatePicker.BaseColor = System.Drawing.Color.White;
            this.toDatePicker.BorderColor = System.Drawing.Color.Silver;
            this.toDatePicker.BorderSize = 1;
            this.toDatePicker.CustomFormat = null;
            this.toDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.toDatePicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.toDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toDatePicker.ForeColor = System.Drawing.Color.Black;
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDatePicker.Location = new System.Drawing.Point(503, 240);
            this.toDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.toDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.toDatePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.toDatePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.toDatePicker.OnPressedColor = System.Drawing.Color.Black;
            this.toDatePicker.Radius = 4;
            this.toDatePicker.Size = new System.Drawing.Size(334, 32);
            this.toDatePicker.TabIndex = 128;
            this.toDatePicker.Text = "5/17/2022";
            this.toDatePicker.Value = new System.DateTime(2022, 5, 17, 14, 30, 22, 650);
            // 
            // rentButton
            // 
            this.rentButton.Animated = true;
            this.rentButton.AnimationHoverSpeed = 0.07F;
            this.rentButton.AnimationSpeed = 0.03F;
            this.rentButton.BackColor = System.Drawing.Color.Transparent;
            this.rentButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rentButton.BorderColor = System.Drawing.Color.Black;
            this.rentButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rentButton.FocusedColor = System.Drawing.Color.Empty;
            this.rentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentButton.ForeColor = System.Drawing.Color.White;
            this.rentButton.Image = null;
            this.rentButton.ImageSize = new System.Drawing.Size(20, 20);
            this.rentButton.Location = new System.Drawing.Point(862, 549);
            this.rentButton.Margin = new System.Windows.Forms.Padding(2);
            this.rentButton.Name = "rentButton";
            this.rentButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.rentButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.rentButton.OnHoverForeColor = System.Drawing.Color.White;
            this.rentButton.OnHoverImage = null;
            this.rentButton.OnPressedColor = System.Drawing.Color.Black;
            this.rentButton.Radius = 4;
            this.rentButton.Size = new System.Drawing.Size(127, 32);
            this.rentButton.TabIndex = 56;
            this.rentButton.Text = "Thuê phòng";
            this.rentButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rentButton.Click += new System.EventHandler(this.rentButton_Click);
            // 
            // fromTimePicker
            // 
            this.fromTimePicker.EditValue = new System.DateTime(2022, 6, 2, 0, 0, 0, 0);
            this.fromTimePicker.Enabled = false;
            this.fromTimePicker.Location = new System.Drawing.Point(846, 181);
            this.fromTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fromTimePicker.Name = "fromTimePicker";
            this.fromTimePicker.Properties.AutoHeight = false;
            this.fromTimePicker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromTimePicker.Size = new System.Drawing.Size(143, 34);
            this.fromTimePicker.TabIndex = 131;
            // 
            // toTimePicker
            // 
            this.toTimePicker.EditValue = new System.DateTime(2022, 6, 2, 0, 0, 0, 0);
            this.toTimePicker.Location = new System.Drawing.Point(846, 240);
            this.toTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.toTimePicker.Name = "toTimePicker";
            this.toTimePicker.Properties.AutoHeight = false;
            this.toTimePicker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toTimePicker.Size = new System.Drawing.Size(143, 32);
            this.toTimePicker.TabIndex = 132;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(499, 295);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(100, 21);
            this.gunaLabel6.TabIndex = 133;
            this.gunaLabel6.Text = "Khách hàng";
            // 
            // phoneEL
            // 
            this.phoneEL.AutoSize = true;
            this.phoneEL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneEL.ForeColor = System.Drawing.Color.Red;
            this.phoneEL.Location = new System.Drawing.Point(650, 381);
            this.phoneEL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneEL.Name = "phoneEL";
            this.phoneEL.Size = new System.Drawing.Size(112, 15);
            this.phoneEL.TabIndex = 138;
            this.phoneEL.Text = "Error will be like this";
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.Location = new System.Drawing.Point(648, 326);
            this.gunaLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(93, 19);
            this.gunaLabel10.TabIndex = 137;
            this.gunaLabel10.Text = "Số điện thoại";
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
            this.phoneTextBox.Location = new System.Drawing.Point(651, 348);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.phoneTextBox.PasswordChar = '\0';
            this.phoneTextBox.Radius = 4;
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.Size = new System.Drawing.Size(246, 32);
            this.phoneTextBox.TabIndex = 136;
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            this.phoneTextBox.Leave += new System.EventHandler(this.phoneTextBox_Leave);
            this.phoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.phoneTextBox_Validating);
            // 
            // fullnameEL
            // 
            this.fullnameEL.AutoSize = true;
            this.fullnameEL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameEL.ForeColor = System.Drawing.Color.Red;
            this.fullnameEL.Location = new System.Drawing.Point(9, 54);
            this.fullnameEL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullnameEL.Name = "fullnameEL";
            this.fullnameEL.Size = new System.Drawing.Size(112, 15);
            this.fullnameEL.TabIndex = 141;
            this.fullnameEL.Text = "Error will be like this";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(10, 2);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(71, 19);
            this.gunaLabel8.TabIndex = 140;
            this.gunaLabel8.Text = "Họ và Tên";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.fullnameTextBox.BaseColor = System.Drawing.Color.White;
            this.fullnameTextBox.BorderColor = System.Drawing.Color.Silver;
            this.fullnameTextBox.BorderSize = 1;
            this.fullnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullnameTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.fullnameTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fullnameTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.fullnameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fullnameTextBox.Location = new System.Drawing.Point(8, 21);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.fullnameTextBox.PasswordChar = '\0';
            this.fullnameTextBox.Radius = 4;
            this.fullnameTextBox.SelectedText = "";
            this.fullnameTextBox.Size = new System.Drawing.Size(339, 34);
            this.fullnameTextBox.TabIndex = 139;
            this.fullnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fullnameTextBox_KeyPress);
            this.fullnameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.fullnameTextBox_Validating);
            // 
            // idEL
            // 
            this.idEL.AutoSize = true;
            this.idEL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idEL.ForeColor = System.Drawing.Color.Red;
            this.idEL.Location = new System.Drawing.Point(10, 122);
            this.idEL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idEL.Name = "idEL";
            this.idEL.Size = new System.Drawing.Size(112, 15);
            this.idEL.TabIndex = 144;
            this.idEL.Text = "Error will be like this";
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.Location = new System.Drawing.Point(9, 69);
            this.gunaLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(103, 19);
            this.gunaLabel11.TabIndex = 143;
            this.gunaLabel11.Text = "CMND / CCCD";
            this.gunaLabel11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // idTexBox
            // 
            this.idTexBox.BackColor = System.Drawing.Color.Transparent;
            this.idTexBox.BaseColor = System.Drawing.Color.White;
            this.idTexBox.BorderColor = System.Drawing.Color.Silver;
            this.idTexBox.BorderSize = 1;
            this.idTexBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTexBox.FocusedBaseColor = System.Drawing.Color.White;
            this.idTexBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.idTexBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.idTexBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idTexBox.Location = new System.Drawing.Point(8, 89);
            this.idTexBox.Name = "idTexBox";
            this.idTexBox.Padding = new System.Windows.Forms.Padding(5);
            this.idTexBox.PasswordChar = '\0';
            this.idTexBox.Radius = 4;
            this.idTexBox.SelectedText = "";
            this.idTexBox.Size = new System.Drawing.Size(339, 34);
            this.idTexBox.TabIndex = 142;
            this.idTexBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTexBox_KeyPress);
            this.idTexBox.Validating += new System.ComponentModel.CancelEventHandler(this.idTexBox_Validating);
            // 
            // deleteButton
            // 
            this.deleteButton.Animated = true;
            this.deleteButton.AnimationHoverSpeed = 0.07F;
            this.deleteButton.AnimationSpeed = 0.03F;
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BaseColor = System.Drawing.Color.Red;
            this.deleteButton.BorderColor = System.Drawing.Color.Black;
            this.deleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteButton.FocusedColor = System.Drawing.Color.Empty;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Image = null;
            this.deleteButton.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteButton.Location = new System.Drawing.Point(753, 549);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteButton.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteButton.OnHoverImage = null;
            this.deleteButton.OnPressedColor = System.Drawing.Color.Black;
            this.deleteButton.Radius = 4;
            this.deleteButton.Size = new System.Drawing.Size(105, 32);
            this.deleteButton.TabIndex = 146;
            this.deleteButton.Text = "Hủy phòng";
            this.deleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // takePicButton
            // 
            this.takePicButton.Animated = true;
            this.takePicButton.AnimationHoverSpeed = 0.07F;
            this.takePicButton.AnimationSpeed = 0.03F;
            this.takePicButton.BackColor = System.Drawing.Color.Transparent;
            this.takePicButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.takePicButton.BorderColor = System.Drawing.Color.Black;
            this.takePicButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.takePicButton.FocusedColor = System.Drawing.Color.Empty;
            this.takePicButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takePicButton.ForeColor = System.Drawing.Color.White;
            this.takePicButton.Image = null;
            this.takePicButton.ImageSize = new System.Drawing.Size(20, 20);
            this.takePicButton.Location = new System.Drawing.Point(504, 488);
            this.takePicButton.Margin = new System.Windows.Forms.Padding(2);
            this.takePicButton.Name = "takePicButton";
            this.takePicButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.takePicButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.takePicButton.OnHoverForeColor = System.Drawing.Color.White;
            this.takePicButton.OnHoverImage = null;
            this.takePicButton.OnPressedColor = System.Drawing.Color.Black;
            this.takePicButton.Radius = 4;
            this.takePicButton.Size = new System.Drawing.Size(133, 32);
            this.takePicButton.TabIndex = 147;
            this.takePicButton.Text = "Upload";
            this.takePicButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.takePicButton.Click += new System.EventHandler(this.takePicButton_Click);
            // 
            // infoLockPanel
            // 
            this.infoLockPanel.Controls.Add(this.idTexBox);
            this.infoLockPanel.Controls.Add(this.fullnameTextBox);
            this.infoLockPanel.Controls.Add(this.gunaLabel8);
            this.infoLockPanel.Controls.Add(this.idEL);
            this.infoLockPanel.Controls.Add(this.fullnameEL);
            this.infoLockPanel.Controls.Add(this.gunaLabel11);
            this.infoLockPanel.Location = new System.Drawing.Point(643, 390);
            this.infoLockPanel.Margin = new System.Windows.Forms.Padding(2);
            this.infoLockPanel.Name = "infoLockPanel";
            this.infoLockPanel.Size = new System.Drawing.Size(362, 155);
            this.infoLockPanel.TabIndex = 148;
            // 
            // findPhoneButton
            // 
            this.findPhoneButton.Animated = true;
            this.findPhoneButton.AnimationHoverSpeed = 0.07F;
            this.findPhoneButton.AnimationSpeed = 0.03F;
            this.findPhoneButton.BackColor = System.Drawing.Color.Transparent;
            this.findPhoneButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.findPhoneButton.BorderColor = System.Drawing.Color.Black;
            this.findPhoneButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.findPhoneButton.FocusedColor = System.Drawing.Color.Empty;
            this.findPhoneButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPhoneButton.ForeColor = System.Drawing.Color.White;
            this.findPhoneButton.Image = null;
            this.findPhoneButton.ImageSize = new System.Drawing.Size(20, 20);
            this.findPhoneButton.Location = new System.Drawing.Point(907, 348);
            this.findPhoneButton.Margin = new System.Windows.Forms.Padding(2);
            this.findPhoneButton.Name = "findPhoneButton";
            this.findPhoneButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.findPhoneButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.findPhoneButton.OnHoverForeColor = System.Drawing.Color.White;
            this.findPhoneButton.OnHoverImage = null;
            this.findPhoneButton.OnPressedColor = System.Drawing.Color.Black;
            this.findPhoneButton.Radius = 4;
            this.findPhoneButton.Size = new System.Drawing.Size(83, 32);
            this.findPhoneButton.TabIndex = 150;
            this.findPhoneButton.Text = "Tìm";
            this.findPhoneButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.findPhoneButton.Click += new System.EventHandler(this.findPhoneButton_Click);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(502, 328);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(34, 19);
            this.gunaLabel9.TabIndex = 151;
            this.gunaLabel9.Text = "Ảnh";
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel12.Location = new System.Drawing.Point(492, 112);
            this.gunaLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(89, 21);
            this.gunaLabel12.TabIndex = 152;
            this.gunaLabel12.Text = "Giá phòng: ";
            // 
            // pricePerHoursLabel
            // 
            this.pricePerHoursLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerHoursLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pricePerHoursLabel.Location = new System.Drawing.Point(578, 110);
            this.pricePerHoursLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pricePerHoursLabel.Name = "pricePerHoursLabel";
            this.pricePerHoursLabel.Size = new System.Drawing.Size(298, 28);
            this.pricePerHoursLabel.TabIndex = 153;
            this.pricePerHoursLabel.Text = "0đ";
            this.pricePerHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showQRCodeButton
            // 
            this.showQRCodeButton.Animated = true;
            this.showQRCodeButton.AnimationHoverSpeed = 0.07F;
            this.showQRCodeButton.AnimationSpeed = 0.03F;
            this.showQRCodeButton.BackColor = System.Drawing.Color.Transparent;
            this.showQRCodeButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.showQRCodeButton.BorderColor = System.Drawing.Color.Black;
            this.showQRCodeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.showQRCodeButton.FocusedColor = System.Drawing.Color.Empty;
            this.showQRCodeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showQRCodeButton.ForeColor = System.Drawing.Color.White;
            this.showQRCodeButton.Image = null;
            this.showQRCodeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.showQRCodeButton.Location = new System.Drawing.Point(907, 143);
            this.showQRCodeButton.Margin = new System.Windows.Forms.Padding(2);
            this.showQRCodeButton.Name = "showQRCodeButton";
            this.showQRCodeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.showQRCodeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.showQRCodeButton.OnHoverForeColor = System.Drawing.Color.White;
            this.showQRCodeButton.OnHoverImage = null;
            this.showQRCodeButton.OnPressedColor = System.Drawing.Color.Black;
            this.showQRCodeButton.Radius = 4;
            this.showQRCodeButton.Size = new System.Drawing.Size(83, 32);
            this.showQRCodeButton.TabIndex = 154;
            this.showQRCodeButton.Text = "QR code";
            this.showQRCodeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.showQRCodeButton.Click += new System.EventHandler(this.showQRCodeButton_Click);
            // 
            // picPicture
            // 
            this.picPicture.BaseColor = System.Drawing.Color.White;
            this.picPicture.Image = global::Hotel.Properties.Resources.cleaning_staff5;
            this.picPicture.InitialImage = global::Hotel.Properties.Resources.cleaning_staff6;
            this.picPicture.Location = new System.Drawing.Point(505, 351);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(130, 130);
            this.picPicture.TabIndex = 155;
            this.picPicture.TabStop = false;
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 690);
            this.Controls.Add(this.picPicture);
            this.Controls.Add(this.showQRCodeButton);
            this.Controls.Add(this.pricePerHoursLabel);
            this.Controls.Add(this.gunaLabel12);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.findPhoneButton);
            this.Controls.Add(this.takePicButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.phoneEL);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.toTimePicker);
            this.Controls.Add(this.fromTimePicker);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.rentButton);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.roomDescLabel);
            this.Controls.Add(this.currTableLabel);
            this.Controls.Add(this.tableListView);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.infoLockPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "      ";
            this.Load += new System.EventHandler(this.RoomsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fromTimePicker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toTimePicker.Properties)).EndInit();
            this.infoLockPanel.ResumeLayout(false);
            this.infoLockPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView tableListView;
        private Guna.UI.WinForms.GunaLabel currTableLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel totalPriceLabel;
        private Guna.UI.WinForms.GunaButton checkoutButton;
        private Guna.UI.WinForms.GunaLabel roomDescLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaDateTimePicker fromDatePicker;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaDateTimePicker toDatePicker;
        private Guna.UI.WinForms.GunaButton rentButton;
        private DevExpress.XtraEditors.TimeEdit fromTimePicker;
        private DevExpress.XtraEditors.TimeEdit toTimePicker;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel phoneEL;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaTextBox phoneTextBox;
        private Guna.UI.WinForms.GunaLabel fullnameEL;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox fullnameTextBox;
        private Guna.UI.WinForms.GunaLabel idEL;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaTextBox idTexBox;
        private Guna.UI.WinForms.GunaButton deleteButton;
        private Guna.UI.WinForms.GunaButton takePicButton;
        private Guna.UI.WinForms.GunaPanel infoLockPanel;
        private Guna.UI.WinForms.GunaButton findPhoneButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaLabel pricePerHoursLabel;
        private Guna.UI.WinForms.GunaButton showQRCodeButton;
        private Guna.UI.WinForms.GunaPictureBox picPicture;
    }
}

namespace Hotel
{
    partial class CustomersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.staffsTable = new Guna.UI.WinForms.GunaDataGridView();
            this.avatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.staffsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Animated = true;
            this.searchButton.AnimationHoverSpeed = 0.07F;
            this.searchButton.AnimationSpeed = 0.03F;
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.searchButton.BorderColor = System.Drawing.Color.Black;
            this.searchButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchButton.FocusedColor = System.Drawing.Color.Empty;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Image = null;
            this.searchButton.ImageSize = new System.Drawing.Size(20, 20);
            this.searchButton.Location = new System.Drawing.Point(923, 63);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.searchButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchButton.OnHoverForeColor = System.Drawing.Color.White;
            this.searchButton.OnHoverImage = null;
            this.searchButton.OnPressedColor = System.Drawing.Color.Black;
            this.searchButton.Radius = 4;
            this.searchButton.Size = new System.Drawing.Size(67, 31);
            this.searchButton.TabIndex = 116;
            this.searchButton.Text = "Search";
            this.searchButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(12, 70);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(182, 21);
            this.gunaLabel6.TabIndex = 114;
            this.gunaLabel6.Text = "Danh sách khách hàng";
            // 
            // staffsTable
            // 
            this.staffsTable.AllowDrop = true;
            this.staffsTable.AllowUserToAddRows = false;
            this.staffsTable.AllowUserToDeleteRows = false;
            this.staffsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.staffsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.staffsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffsTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.staffsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.staffsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.staffsTable.ColumnHeadersHeight = 50;
            this.staffsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.avatar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.staffsTable.EnableHeadersVisualStyles = false;
            this.staffsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.staffsTable.Location = new System.Drawing.Point(16, 110);
            this.staffsTable.Name = "staffsTable";
            this.staffsTable.ReadOnly = true;
            this.staffsTable.RowHeadersVisible = false;
            this.staffsTable.RowHeadersWidth = 62;
            this.staffsTable.RowTemplate.Height = 28;
            this.staffsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffsTable.Size = new System.Drawing.Size(974, 555);
            this.staffsTable.TabIndex = 113;
            this.staffsTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.staffsTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.staffsTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.staffsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.staffsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.staffsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.staffsTable.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.staffsTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.staffsTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.staffsTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.staffsTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffsTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.staffsTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.staffsTable.ThemeStyle.HeaderStyle.Height = 50;
            this.staffsTable.ThemeStyle.ReadOnly = true;
            this.staffsTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.staffsTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.staffsTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffsTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.staffsTable.ThemeStyle.RowsStyle.Height = 28;
            this.staffsTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.staffsTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // avatar
            // 
            this.avatar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.avatar.DataPropertyName = "avatar";
            this.avatar.HeaderText = "avatar";
            this.avatar.MinimumWidth = 8;
            this.avatar.Name = "avatar";
            this.avatar.ReadOnly = true;
            this.avatar.Visible = false;
            this.avatar.Width = 150;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BackColor = System.Drawing.Color.Transparent;
            this.searchTextBox.BaseColor = System.Drawing.Color.White;
            this.searchTextBox.BorderColor = System.Drawing.Color.Silver;
            this.searchTextBox.BorderSize = 1;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.searchTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.searchTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTextBox.Location = new System.Drawing.Point(739, 63);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.Radius = 4;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(179, 31);
            this.searchTextBox.TabIndex = 115;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(8, 6);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(214, 47);
            this.gunaLabel1.TabIndex = 112;
            this.gunaLabel1.Text = "Khách hàng";
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 675);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.staffsTable);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.gunaLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton searchButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaDataGridView staffsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatar;
        private Guna.UI.WinForms.GunaTextBox searchTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
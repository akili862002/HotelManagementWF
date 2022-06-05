using Hotel.Databases;
using Hotel.Entities;
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
    public partial class ScheduleForm : Form
    {
        List<ListBox> listListBox = new List<ListBox>();
        List<ManagerEntity> managers = new List<ManagerEntity>();
        List<StaffEntity> receptions = new List<StaffEntity>();
        List<StaffEntity> labors = new List<StaffEntity>();
        int staff_id = 0;
        int manager_id = 0;

        public ScheduleForm()
        {
            InitializeComponent();
            listListBox.Add(this.listBox1);
            listListBox.Add(this.listBox2);
            listListBox.Add(this.listBox3);
            listListBox.Add(this.listBox4);
            listListBox.Add(this.listBox5);
            listListBox.Add(this.listBox6);
            listListBox.Add(this.listBox7);
            listListBox.Add(this.listBox8);
            listListBox.Add(this.listBox9);
            listListBox.Add(this.listBox10);
            listListBox.Add(this.listBox11);
            listListBox.Add(this.listBox12);
            listListBox.Add(this.listBox13);
            listListBox.Add(this.listBox14);
            listListBox.Add(this.listBox15);
            listListBox.Add(this.listBox16);
            listListBox.Add(this.listBox17);
            listListBox.Add(this.listBox18);
            listListBox.Add(this.listBox19);
            listListBox.Add(this.listBox20);
            listListBox.Add(this.listBox21);
            listListBox.Add(this.listBox22);
            listListBox.Add(this.listBox23);
            listListBox.Add(this.listBox24);
            listListBox.Add(this.listBox25);
            listListBox.Add(this.listBox26);
            listListBox.Add(this.listBox27);
            listListBox.Add(this.listBox28);
            listListBox.Add(this.listBox29);
            listListBox.Add(this.listBox30);
            listListBox.Add(this.listBox31);
            listListBox.Add(this.listBox32);
            listListBox.Add(this.listBox33);
            listListBox.Add(this.listBox34);
            listListBox.Add(this.listBox35);
            listListBox.Add(this.listBox36);
            listListBox.Add(this.listBox37);
            listListBox.Add(this.listBox38);
            listListBox.Add(this.listBox39);
            listListBox.Add(this.listBox40);
            listListBox.Add(this.listBox41);
            listListBox.Add(this.listBox42);
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            this.initDataSchedule();
        }

        private void loadStaffs()
        {
            ManagerDB managerDB = new ManagerDB();
            this.managers = managerDB.getAllList();

            StaffDB staffDB = new StaffDB();
            this.receptions = staffDB.getAllList(" AND is_reception = 1");
            this.labors = staffDB.getAllList(" AND is_labor = 1");
        }

        private void initDataSchedule()
        {
            this.loadStaffs();
            List<Day> schedule = ScheduleGenerator.generate(managers, receptions, labors);

            int i = 0;
            foreach (Day item in schedule)
            {
                if (this.managerRadio.Checked || this.allRadio.Checked)
                {

                    this.listListBox[i].Items.Clear();
                    foreach (var manager in item.managers)
                    {
                        if (this.managerRadio.Checked && this.manager_id > 0)
                        {
                            if (this.manager_id == manager.manager_id)
                                this.listListBox[i].Items.Add($"QL: {manager.fullname}");
                            continue;
                        }

                        this.listListBox[i].Items.Add($"QL: {manager.fullname}");
                    }
                }

                if (this.receptionRadio.Checked || this.allRadio.Checked)
                {
                    if (!this.allRadio.Checked)
                        this.listListBox[i].Items.Clear();
                    foreach (var reception in item.receptions)
                    {
                        if (this.receptionRadio.Checked && this.staff_id > 0)
                        {
                            if (this.staff_id == reception.staff_id)
                                this.listListBox[i].Items.Add($"TT: {reception.fullname}");
                            continue;
                        }
                        this.listListBox[i].Items.Add($"TT: {reception.fullname}");
                    }
                }

                if (this.laborRadio.Checked || this.allRadio.Checked)
                {
                    if (!this.allRadio.Checked)
                        this.listListBox[i].Items.Clear();
                    foreach (var labor in item.labors)
                    {
                        if (this.laborRadio.Checked && this.staff_id > 0)
                        {
                            if (this.staff_id == labor.staff_id)
                                this.listListBox[i].Items.Add($"LC: {labor.fullname}");
                            continue;
                        }
                        this.listListBox[i].Items.Add($"LC: {labor.fullname}");
                    }
                }

                i++;
            }

        }

        private void managerRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.initDataSchedule();
            this.staffLabel.Text = "Quản lý";
            this.staffComboBox.Enabled = true;
            ManagerDB db = new ManagerDB();
            DataTable dt = new DataTable();
            db.getAllAdapter("*", "").Fill(dt);
            this.staffComboBox.DataSource = dt;
            this.staffComboBox.DisplayMember = "fullname";
            this.staffComboBox.ValueMember = "fullname";
            this.staffComboBox.SelectedIndex = -1;
        }

        private void receptionRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.initDataSchedule();
            this.staffLabel.Text = "Tiếp tân";
            this.staffComboBox.Enabled = true;
            StaffDB db = new StaffDB();
            DataTable dt = new DataTable();
            db.getAllAdapter("*", "", $" AND is_reception = 1").Fill(dt);
            this.staffComboBox.DataSource = dt;
            this.staffComboBox.DisplayMember = "fullname";
            this.staffComboBox.ValueMember = "fullname";
            this.staffComboBox.SelectedIndex = -1;
        }

        private void laborRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.initDataSchedule();
            this.staffLabel.Text = "Lao công";
            this.staffComboBox.Enabled = true;
            StaffDB db = new StaffDB();
            DataTable dt = new DataTable();
            db.getAllAdapter("*", "", $" AND is_labor = 1").Fill(dt);
            this.staffComboBox.DataSource = dt;
            this.staffComboBox.DisplayMember = "fullname";
            this.staffComboBox.ValueMember = "fullname";
            this.staffComboBox.SelectedIndex = -1;
        }

        private void allRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.initDataSchedule();
            this.staffComboBox.Enabled = false;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog.Show();
        }

        private void staffComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)this.staffComboBox.SelectedItem;
            if (row == null)
            {
                this.manager_id = -1;
                this.staff_id = -1;
                this.initDataSchedule();
                return;
            };

            try
            {

                if (this.managerRadio.Checked)
                {
                    this.manager_id = Int32.Parse(row["manager_id"].ToString());
                }
                if (this.receptionRadio.Checked || this.laborRadio.Checked)
                {
                    this.staff_id = Int32.Parse(row["staff_id"].ToString());
                }
            }
            catch
            {

            }

            this.initDataSchedule();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.printPanel.Width, this.printPanel.Height);
            this.printPanel.DrawToBitmap(bm, new Rectangle(0, 0, this.printPanel.Width, this.printPanel.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace timesheet
{
    public partial class frmEditPerson : Form
    {
        DataBase db;
        PersianCalendar calendar;
        Personnel person = null;
        List<Expertise> xps;
        bool HasChangeToSave;
        public frmEditPerson()
        {
            InitializeComponent();
            db = new DataBase();
            calendar = new PersianCalendar();
            xps = db.getExpertise();
            foreach (Expertise xp in xps)
                cbXP.Items.Add(xp.getXp());
            cbXP.SelectedIndex = 0;
            HasChangeToSave = false;
        }
        public frmEditPerson(Personnel person)
        {
            InitializeComponent();
            db = new DataBase();
            calendar = new PersianCalendar();
            this.person = person;
            if (person != null)
                init();
        }

        private void init()
        {
            txtName.Text = person.getName();
            txtRest.Text = person.getRest().ToString();
            txtWork.Text = person.getWork().ToString();
            String[] date = calendar.SplitDate(person.getStart());
            txtRDay.Text = date[2];
            txtRYear.Text = date[0];
            cbRMonth.SelectedIndex = int.Parse(date[1]) - 1;
            xps = db.getExpertise();
            foreach (Expertise xp in xps)
                cbXP.Items.Add(xp.getXp());
            cbXP.SelectedIndex = cbXP.Items.IndexOf(person.getXp());
            HasChangeToSave = false;
        }

        void Toast(string message, MessageBoxIcon type)
        {
            lblToast.Text = message;
            switch (type)
            {
                case MessageBoxIcon.Information:
                    lblToast.BackColor = Color.DarkGray;
                    break;
                case MessageBoxIcon.Error:
                    lblToast.BackColor = Color.Red;
                    break;
                case MessageBoxIcon.Warning:
                    lblToast.BackColor = Color.Orange;
                    break;
                default:
                    lblToast.BackColor = Color.DarkGray;
                    break;
            }
            lblToast.Visible = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!HasChangeToSave)
                HasChangeToSave = true;
            lblToast.Visible = false;
        }

        private void txtRest_TextChanged(object sender, EventArgs e)
        {
            if (!HasChangeToSave)
                HasChangeToSave = true;
            lblToast.Visible = false;
        }

        private void txtWork_TextChanged(object sender, EventArgs e)
        {
            if (!HasChangeToSave)
                HasChangeToSave = true;
            lblToast.Visible = false;
        }

        private void txtRDay_TextChanged(object sender, EventArgs e)
        {
            if (!HasChangeToSave)
                HasChangeToSave = true;
            lblToast.Visible = false;
        }

        private void cbRMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasChangeToSave)
                HasChangeToSave = true;
            lblToast.Visible = false;
        }

        private void txtRYear_TextChanged(object sender, EventArgs e)
        {
            if (!HasChangeToSave)
                HasChangeToSave = true;
            lblToast.Visible = false;
        }

        private void cbXP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!HasChangeToSave)
                HasChangeToSave = true;
            lblToast.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("رکورد جاری پاک شود؟", "پاک کردن رکورد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.deletePerson(person.getId());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (HasChangeToSave)
            {
                try
                {
                    if (txtName.Text == "")
                        Toast("فیلد نام و نام خانوادگی نمیتواند خالی باشد", MessageBoxIcon.Warning);
                    else if (txtRest.Text == "")
                        Toast("فیلد تعداد روزهای مرخصی نمیتواند خالی باشد", MessageBoxIcon.Warning);
                    else if (txtWork.Text == "")
                        Toast("فیلد تعداد روزهای کاری نمیتواند خالی باشد", MessageBoxIcon.Warning);
                    else if (txtRDay.Text == "")
                        Toast("فیلد روز شروع روتیشن نمیتواند خالی باشد", MessageBoxIcon.Warning);
                    else if (txtRYear.Text == "")
                        Toast("فیلد سال شروع روتیشن نمیتواند خالی باشد", MessageBoxIcon.Warning);
                    else if (cbRMonth.Text == "")
                        Toast("فیلد ماه شروع روتیشن نمیتواند خالی باشد", MessageBoxIcon.Warning);
                    else if (cbXP.Text == "")
                        Toast("فیلد تخصص نمیتواند خالی باشد", MessageBoxIcon.Warning);
                    else
                    {
                        bool itsNew;
                        if (person == null) {
                            person = new Personnel();
                            itsNew = true;
                        }
                        else
                            itsNew = false;

                        person.setName(txtName.Text);
                        person.setRest(int.Parse(txtRest.Text));
                        person.setWork(int.Parse(txtWork.Text));
                        person.setStart(txtRYear.Text + "-" + (cbRMonth.SelectedIndex + 1) + "-" + txtRDay.Text);
                        foreach (Expertise xp in xps)
                            if (xp.getXp() == cbXP.Text)
                                person.setXpId(xp.getId());
                        
                        if (itsNew)
                            db.addPerson(person);
                        else
                            db.updatePerson(person);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (System.FormatException)
                {
                    Toast("مقدار وارد شده صحیح نیست!", MessageBoxIcon.Warning);
                }
                catch (System.Exception ex)
                {
                    Toast(ex.Message, MessageBoxIcon.Error);
                }
            }
            else
            {
                Toast("تغییری برای ذخیره انجام نشده است!", MessageBoxIcon.Information);
            }
        }
    }
}

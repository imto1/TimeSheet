using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace timesheet
{
    public partial class frmChange : Form
    {
        Changes change = null;
        DataBase db;
        PersianCalendar calendar;
        bool HasHistory = false;
        bool HasChangeToSave;

        public frmChange()
        {
            InitializeComponent();
            db = new DataBase();
            calendar = new PersianCalendar();
        }
        public frmChange(Changes change)
        {
            InitializeComponent();
            this.change = change;
            db = new DataBase();
            calendar = new PersianCalendar();
            if (change != null)
                init();
        }


        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        void init()
        {
            HasHistory = HistoryCheck(change);
            string[] date = calendar.SplitDate(change.getFromDate());
            lblFrom.Text = date[0] + "-" + date[1] + "-";
            txtFrom.Text = date[2];
            if (change.getToDate() != null)
            {
                date = calendar.SplitDate(change.getToDate());
                lblTo.Text = date[0] + "-" + date[1] + "-";
                txtTo.Text = date[2];
            }
            else
            {
                lblTo.Text = lblFrom.Text;
                txtTo.Text = txtFrom.Text;
            }
            Option3.Text = change.getStatus();
            if (Option3.Text == "R")
            {
                Option3.BackColor = Color.LightPink;
                Option1.BackColor = Color.LightGreen;
                Option2.BackColor = Color.Khaki;
                Option1.Text = "W";
                Option2.Text = "A";
            }
            else if (Option3.Text == "W")
            {
                Option3.BackColor = Color.LightGreen;
                Option1.BackColor = Color.LightPink;
                Option2.BackColor = Color.Khaki;
                Option1.Text = "R";
                Option2.Text = "A";
            }
            else if (Option3.Text == "A")
            {
                Option3.BackColor = Color.Khaki;
                Option1.BackColor = Color.LightGreen;
                Option2.BackColor = Color.LightPink;
                Option1.Text = "W";
                Option2.Text = "R";
            }
            txtReason.Text = change.getReason();
            Personnel person = db.getPerson(change.getPersonId());
            lblName.Text = person.getName();
            HasChangeToSave = !HasHistory;
            btnRemove.Visible = HasHistory;
            HasChangeToSave = false;
        }

        bool HistoryCheck(Changes change)
        {
            string[] date = calendar.SplitDate(change.getFromDate());
            List<Changes> history = db.getChanges(change.getPersonId());
            if (history != null)
                foreach (Changes ch in history)
                    if (InRange(ch.getFromDate(), ch.getToDate(), change.getFromDate()))
                    {
                        this.change = ch;
                        return true;
                    }
            return false;
        }

        bool InRange(string from, string to, string date)
        {
            string[] From = calendar.SplitDate(from);
            string[] To = calendar.SplitDate(to);
            string[] Date = calendar.SplitDate(date);
            int fromYear = int.Parse(From[0]),
                fromMonth = int.Parse(From[1]),
                fromDay = int.Parse(From[2]),
                toYear = int.Parse(To[0]),
                toMonth = int.Parse(To[1]),
                toDay = int.Parse(To[2]),
                dateYear = int.Parse(Date[0]),
                dateMonth = int.Parse(Date[1]),
                dateDay = int.Parse(Date[2]);
            if (dateYear > fromYear ||
                (dateYear >= fromYear && dateMonth > fromMonth) ||
                (dateYear >= fromYear && dateMonth >= fromMonth && dateDay >= fromDay))
                if (dateYear < toYear ||
                    (dateYear <= toYear && dateMonth < toMonth) ||
                    (dateYear <= toYear && dateMonth <= toMonth && dateDay <= toDay))
                    return true;
            return false;
        }

        bool IsGreaterThan(string from, string to)
        {
            string[] From = calendar.SplitDate(from);
            string[] To = calendar.SplitDate(to);
            int fromYear = int.Parse(From[0]),
                fromMonth = int.Parse(From[1]),
                fromDay = int.Parse(From[2]),
                toYear = int.Parse(To[0]),
                toMonth = int.Parse(To[1]),
                toDay = int.Parse(To[2]);
            if (toYear > fromYear ||
                (toYear >= fromYear && toMonth > fromMonth) ||
                (toYear >= fromYear && toMonth >= fromMonth && toDay >= fromDay))
                return true;
            return false;
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            if (HasChangeToSave)
            {
                try
                {
                    if (change != null)
                    {
                        string[] data = lblFrom.Text.Split('-');
                        int maxDay = calendar.getMaxDay(int.Parse(data[0]), int.Parse(data[1]));
                        if (txtFrom.Text == "")
                            Toast("فیلد تاریخ شروع نمیتواند خالی باشد", MessageBoxIcon.Warning);
                        else if (txtTo.Text == "")
                            Toast("فیلد تاریخ پایان نمیتواند خالی باشد", MessageBoxIcon.Warning);
                        else if (txtReason.Text == "")
                            Toast("فیلد علت تغییر نمیتواند خالی باشد", MessageBoxIcon.Warning);
                        else if (int.Parse(txtFrom.Text) > maxDay)
                            Toast("مقدار وارد شده برای شروع، بیشتر از حداکثر روز های ماه می باشد", MessageBoxIcon.Warning);
                        else
                        {
                            change.setFromDate(lblFrom.Text + txtFrom.Text);

                            data = lblTo.Text.Split('-');
                            maxDay = calendar.getMaxDay(int.Parse(data[0]), int.Parse(data[1]));
                            if (int.Parse(txtTo.Text) > maxDay)
                                Toast("مقدار وارد شده برای پایان، بیشتر از حداکثر روز های ماه می باشد", MessageBoxIcon.Warning);
                            else
                            {
                                change.setToDate(lblTo.Text + txtTo.Text);
                                if (IsGreaterThan(change.getFromDate(), change.getToDate()))
                                {
                                    if (Option1.Checked)
                                        change.setStatus(Option1.Text);
                                    else if (Option2.Checked)
                                        change.setStatus(Option2.Text);
                                    else if (Option3.Checked)
                                        change.setStatus(Option3.Text);

                                    change.setReason(txtReason.Text);

                                    if (HasHistory)
                                        db.updateChange(change);
                                    else
                                        db.addChange(change);

                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                                else
                                    Toast("تاریخ پایان نمیتواند قبلتر از تاریخ شروع باشد", MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                        Toast("خطای پیشبینی نشده ای رخ داده است!.", MessageBoxIcon.Error);
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

        private void txtFrom_TextChanged(object sender, System.EventArgs e)
        {
            if (!HasChangeToSave)
                HasChangeToSave = true;
            lblToast.Visible = false;
        }

        private void txtTo_TextChanged(object sender, System.EventArgs e)
        {
            if (!HasChangeToSave)
                HasChangeToSave = true;
            lblToast.Visible = false;
        }

        private void txtReason_TextChanged(object sender, System.EventArgs e)
        {
            if (!HasChangeToSave)
                HasChangeToSave = true;
            lblToast.Visible = false;
        }

        private void Option1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (!HasChangeToSave)
                HasChangeToSave = true;
            lblToast.Visible = false;
        }

        private void Option2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (!HasChangeToSave)
                HasChangeToSave = true;
            lblToast.Visible = false;
        }

        private void btnRemove_Click(object sender, System.EventArgs e)
        {
            if (HasHistory)
                if (MessageBox.Show("رکورد جاری پاک شود؟", "پاک کردن رکورد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.deleteChange(change.getId());
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
        }

        private void Option3_CheckedChanged(object sender, System.EventArgs e)
        {
            if (!HasChangeToSave)
                HasChangeToSave = true;
            lblToast.Visible = false;
        }
    }
}

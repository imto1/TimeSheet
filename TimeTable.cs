using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace timesheet
{
    public partial class TimeTable : Form
    {
        public TimeTable()
        {
            InitializeComponent();
        }

        PersianCalendar calendar;
        DataBase database;
        int MaxDay, SheetY, SheetX, x, y, Year, Month, row, Rest, Work, TotalWork, TotalRest, Height = 20;
        bool HasChange = false;
        List<Object> WeekDaysLabels;
        int[] Available, Total;


        //Name TAGs
        const string DAY_OF_WEEK = "DayOfWeek";
        const string DAY_OF_MONTH = "DayOfMonth";
        const string ROW = "Row";
        const string PERSON = "Person";
        const string PERSON_WORK = "PersonWork";
        const string PERSON_REST = "PersonRest";
        const string GROUP_WORK = "GroupWork";
        const string GROUP_REST = "GroupRest";
        const string WORK_COUNT = "WorkCount";
        const string REST_COUNT = "RestCount";
        const string GROUP = "Group";
        const string AVAILABLE = "Available";
        const string AVAILABLE_COUNT = "AvailableCount";
        const string COUNT = "CountAll";


        private void btnNow_Click(object sender, EventArgs e)
        {
            Year = calendar.Year();
            Month = calendar.Month();
            //ClearForm();
            FillHeaders();
            FillTable();
            this.Refresh();
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            var GoTo = new frmGoTo(Year, Month);
            if(GoTo.ShowDialog() == DialogResult.OK)
            {
                Year = GoTo.year;
                Month = GoTo.month;
                FillHeaders();
                FillTable();
                this.Refresh();
            }
        }

        private void llblProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("https://www.instagram.com/s_vahid_h/");
            System.Diagnostics.Process.Start(info);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            //ClearForm();
            if (Month > 1)
                Month--;
            else
            {
                Year--;
                Month = 12;
            }
            FillHeaders();
            FillTable();
            this.Refresh();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //ClearForm();
            if (Month < 12)
                Month++;
            else
            {
                Year++;
                Month = 1;
            }
            FillHeaders();
            FillTable();
            this.Refresh();
        }

        private void TimeTable_Load(object sender, EventArgs e)
        {
            calendar = new PersianCalendar();
            database = new DataBase();
            WeekDaysLabels = new List<object>();
            Year = calendar.Year();
            Month = calendar.Month();
            init();
            FillHeaders();
            FillTable();
        }

        void init()
        {
            SheetY = lblDepartment.Location.Y + lblDepartment.Height;
            SheetX = lblDepartment.Location.X + lblDepartment.Width;
            y = SheetY - 1;
            x = SheetX - 1;

            for (int i = 1; i <= 31; i++)
            {
                AddLabel(DAY_OF_WEEK + i, "",
                    new Point(x, y), new Size(25, 25), Color.White);
                x += 25;
            }
            y += 25;
            x = SheetX - 1;
            for (int i = 1; i <= 31; i++)
            {
                AddLabel(DAY_OF_MONTH + i, "" + i, new Point(x, y), new Size(25, 25), Color.White);
                x += 25;
            }
            y += 25;
            //
            List<Expertise> expertise = database.getExpertise();
            foreach (Expertise xp in expertise)
            {
                List<Personnel> personnel = database.getPersonnel(xp.getId());
                row = 0;
                foreach (Personnel person in personnel)
                {
                    x = SheetX - 1;

                    AddLabel(ROW + xp.getId() + "-" + (++row), row.ToString(), new Point(lblRowTitle.Location.X, y),
                        new Size(lblRowTitle.Width, Height), Color.White);
                    AddLabel(PERSON + person.getId(), person.getName(),
                        new Point(lblNameTitle.Location.X, y), new Size(lblNameTitle.Width, Height), Color.White);

                    for (int i = 1; i <= 31; i++)
                    {
                        AddLabel(PERSON + person.getId() + "-" + i,
                            "", new Point(x, y), new Size(25, Height), Color.White);
                        x += 25;
                    }
                    AddLabel(PERSON_WORK + person.getId(), "",
                        new Point(lblWorkCount.Location.X, y), new Size(lblWorkCount.Width, Height), Color.White);
                    AddLabel(PERSON_REST + person.getId(), "",
                        new Point(lblRestCount.Location.X, y), new Size(lblRestCount.Width, Height), Color.White);
                    y += Height;
                }
                x = SheetX - 1;
                AddLabel(GROUP + xp.getId(), "جمع " + personnel[0].getXp(),
                    new Point(lblDepartment.Location.X, y), new Size(lblDepartment.Width, Height), Color.LightGray);
                for (int i = 0; i <= 30; i++)
                {
                    AddLabel(AVAILABLE + xp.getId() + "-" + i, "", new Point(x, y),
                    new Size(lblRowTitle.Width, Height), Color.LightGray);
                    x += 25;
                }
                AddLabel(GROUP_WORK + xp.getId(), "", new Point(lblWorkCount.Location.X, y),
                    new Size(lblWorkCount.Width, Height), Color.LightGray);
                AddLabel(GROUP_REST + xp.getId(), "", new Point(lblRestCount.Location.X, y),
                    new Size(lblRestCount.Width, Height), Color.LightGray);
                y += Height;
            }

            x = SheetX - 1;
            AddLabel(COUNT, "جمع کل ",
                new Point(lblDepartment.Location.X, y), new Size(lblDepartment.Width, Height), Color.LightGray);
            for (int i = 0; i <= 30; i++)
            {
                AddLabel(AVAILABLE_COUNT + i, "", new Point(x, y),
                new Size(lblRowTitle.Width, Height), Color.LightGray);
                x += 25;
            }
            AddLabel(WORK_COUNT, "", new Point(lblWorkCount.Location.X, y),
                new Size(lblWorkCount.Width, Height), Color.LightGray);
            AddLabel(REST_COUNT, "", new Point(lblRestCount.Location.X, y),
                new Size(lblRestCount.Width, Height), Color.LightGray);
            y += Height;
        }

        void FillHeaders()
        {
            MaxDay = calendar.getMaxDay(Year, Month);
            lblWorkMonth.Text = calendar.getMonthName(Month) + " " + Year;

            bool weekChanged = false;
            for (int i = 1; i <= MaxDay; i++)
            {
                String date = Year + "-" + Month + "-" + i;
                int weekDay = calendar.getDayOfWeek(date);
                if (weekDay == 6)
                    weekChanged = !weekChanged;
                Color color;
                if (Year == calendar.Year() && Month == calendar.Month() && i == calendar.Day())
                    color = Color.LightBlue;
                else if (weekChanged)
                    color = Color.SkyBlue;
                else
                    color = Color.Wheat;
                this.Controls[DAY_OF_WEEK + i].Text = calendar.getWeekChar(weekDay);
                this.Controls[DAY_OF_WEEK + i].BackColor = color;
            }
            if (MaxDay < 31)
                for (int i = MaxDay + 1; i <= 31; i++)
                {
                    this.Controls[DAY_OF_WEEK + i].Text = "";
                    this.Controls[DAY_OF_WEEK + i].BackColor = Color.White;
                }

            for (int i = 1; i <= MaxDay; i++)
            {
                this.Controls[DAY_OF_MONTH + i].Text = "" + i;
                if (Year == calendar.Year() && Month == calendar.Month() && i == calendar.Day())
                    this.Controls[DAY_OF_MONTH + i].BackColor = Color.LightBlue;
                else
                    this.Controls[DAY_OF_MONTH + i].BackColor = this.Controls[DAY_OF_WEEK + i].BackColor;
            }
            if (MaxDay < 31)
                for (int i = MaxDay + 1; i <= 31; i++)
                {
                    this.Controls[DAY_OF_MONTH + i].Text = "";
                    this.Controls[DAY_OF_MONTH + i].BackColor = Color.White;
                }
        }

        void FillTable()
        {
            List<Expertise> expertise = database.getExpertise();
            TotalWork = TotalRest = 0;
            Total = new int[MaxDay];

            foreach (Expertise xp in expertise)
                LoadTimeSheet(xp.getId());

            for (int i = 0; i < Total.Length; i++)
            {
                this.Controls[AVAILABLE_COUNT + i].Text = Total[i].ToString();
                if (Year == calendar.Year() && Month == calendar.Month() && (i + 1) == calendar.Day())
                    this.Controls[AVAILABLE_COUNT + i].BackColor = Color.LightBlue;
                else
                    this.Controls[AVAILABLE_COUNT + i].BackColor = Color.LightGray;
            }
            if (Total.Length < 31)
                for (int i = Total.Length; i < 31; i++)
                {
                    this.Controls[AVAILABLE_COUNT + i].Text = "";
                    this.Controls[AVAILABLE_COUNT + i].BackColor = Color.White;
                }
            this.Controls[WORK_COUNT].Text = TotalWork.ToString();
            this.Controls[REST_COUNT].Text = TotalRest.ToString();
        }

        void LoadTimeSheet(int expertise)
        {
            List<Personnel> personnel = database.getPersonnel(expertise);
            Available = new int[MaxDay];
            Rest = Work = row = 0;
            foreach (Personnel person in personnel)
            {
                TimeSheet ts = new TimeSheet(person.getWork(), person.getRest(), person.getStart());
                String rests = ts.getRestDays(Year, Month);
                String[] Rests = rests.Split('~');
                List<String> rest = new List<string>(Rests);
                AddPerson(person.getId(), person.getName(), rest);
            }

            for (int i = 0; i < Available.Length; i++)
            {
                this.Controls[AVAILABLE + expertise + "-" + i].Text = Available[i].ToString();
                if (Year == calendar.Year() && Month == calendar.Month() && (i + 1) == calendar.Day())
                    this.Controls[AVAILABLE + expertise + "-" + i].BackColor = Color.LightBlue;
                else
                    this.Controls[AVAILABLE + expertise + "-" + i].BackColor = Color.LightGray;
            }
            if (Available.Length < 31)
                for (int i = Available.Length; i < 31; i++)
                {
                    this.Controls[AVAILABLE + expertise + "-" + i].Text = "";
                    this.Controls[AVAILABLE + expertise + "-" + i].BackColor = Color.White;
                }
            this.Controls[GROUP_WORK + expertise].Text = Work.ToString();
            TotalWork += Work;
            this.Controls[GROUP_REST + expertise].Text = Rest.ToString();
            TotalRest += Rest;
        }

        void AddPerson(int id, String name, List<String> rest)
        {
            String dayStatus = "W";
            Color color = Color.LightGreen;
            int from, to, WORK, REST;
            from = to = WORK = REST = 0;
            string changeStatus = dayStatus;
            for (int i = 1; i <= MaxDay; i++)
            {
                Changes change = database.getChange(id, (Year + "-" + Month + "-" + i));
                if (change.getId() != 0)
                {
                    HasChange = true;
                    string[] date = calendar.SplitDate(change.getFromDate());
                    from = int.Parse(date[2]);
                    date = calendar.SplitDate(change.getToDate());
                    to = int.Parse(date[2]);
                    dayStatus = changeStatus = change.getStatus();
                    color = Color.MediumPurple;
                }
                else if (HasChange && (i >= from && i <= to))
                {
                    dayStatus = changeStatus;
                    color = Color.MediumPurple;
                }
                else
                {
                    if (rest.Contains(i.ToString()))
                        dayStatus = "R";
                    else
                        dayStatus = "W";

                    if (dayStatus == "W")
                        color = Color.LightGreen;
                    else if (dayStatus == "R")
                        color = Color.LightPink;
                }
                if (Year == calendar.Year() && Month == calendar.Month() && i == calendar.Day())
                    color = Color.LightBlue;
                else if (dayStatus == "A")
                    color = Color.Khaki;

                if (dayStatus == "W")
                {
                    Available[i - 1]++;
                    Total[i - 1]++;
                    WORK++;
                }
                else if (dayStatus == "R")
                    REST++;

                this.Controls[PERSON + id + "-" + i].Text = dayStatus;
                this.Controls[PERSON + id + "-" + i].Tag = dayStatus + "~" + id + "~" + Year + "~" + Month + "~" + i;
                this.Controls[PERSON + id + "-" + i].BackColor = color;
            }
            if (MaxDay < 31)
                for (int i = MaxDay + 1; i <= 31; i++)
                {
                    this.Controls[PERSON + id + "-" + i].Text = "";
                    this.Controls[PERSON + id + "-" + i].Tag = null;
                    this.Controls[PERSON + id + "-" + i].BackColor = Color.White;
                }
            this.Controls[PERSON_WORK + id].Text = (WORK).ToString();
            this.Controls[PERSON_REST + id].Text = (REST).ToString();
            Work += WORK;
            Rest += REST;
        }

        void AddLabel(String name, String text, Point point, Size size, Color color)
        {
            Label lbl = new Label();
            Object label;
            lbl.Name = name;
            lbl.Location = point;
            lbl.Text = text;
            lbl.AutoSize = false;
            lbl.Size = size;
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.BackColor = color;
            lbl.Click += new EventHandler(DayClick);
            this.Controls.Add(lbl);
        }

        void Represent(List<Object> objects)
        {
            foreach (Object obj in objects)
                this.Controls.Add((Label)obj);
        }

        void ClearForm()
        {
            List<String> header = new List<string> { "lblDepartment", "lblWorkMonth", "lblWeekDayTitle",
                "lblRowTitle", "lblNameTitle", "lblWorkCount", "lblRestCount", "btnPrev", "btnNext", "llblProfile", "btnNow", "btnGoTo" };
            while (this.Controls.Count > header.Count)
            {
                foreach (Control control in this.Controls)
                {
                    if (!header.Contains(control.Name))
                        control.Dispose();
                }
            }

        }

        private void DayClick(Object sender, EventArgs e)
        {
            Label control = (Label)sender;
            string[] data;
            if (control.Tag != null)
            {
                data = control.Tag.ToString().Split('~');
                if (data[0] == "W" || data[0] == "R" || data[0] == "A")
                {
                    Changes change = new Changes(int.Parse(data[1]), (data[2] + "-" + data[3] + "-" + data[4]), data[0]);
                    Form Change = new frmChange(change);
                    if (Change.ShowDialog() == DialogResult.OK)
                    {
                        FillHeaders();
                        FillTable();
                        this.Refresh();
                    }
                }
            }
        }
    }
}

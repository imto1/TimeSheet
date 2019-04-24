namespace timesheet
{
    partial class TimeTable
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
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblWorkMonth = new System.Windows.Forms.Label();
            this.lblWorkCount = new System.Windows.Forms.Label();
            this.lblRestCount = new System.Windows.Forms.Label();
            this.lblWeekDayTitle = new System.Windows.Forms.Label();
            this.lblRowTitle = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.llblProfile = new System.Windows.Forms.LinkLabel();
            this.btnNow = new System.Windows.Forms.Button();
            this.btnGoTo = new System.Windows.Forms.Button();
            this.btnAddPersonnel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDepartment
            // 
            this.lblDepartment.BackColor = System.Drawing.Color.White;
            this.lblDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDepartment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDepartment.Location = new System.Drawing.Point(0, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(185, 39);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "پیشخوان خدمات فناوری اطلاعات و ارتباطات ستاد";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWorkMonth
            // 
            this.lblWorkMonth.BackColor = System.Drawing.Color.White;
            this.lblWorkMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWorkMonth.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWorkMonth.Location = new System.Drawing.Point(184, 0);
            this.lblWorkMonth.Name = "lblWorkMonth";
            this.lblWorkMonth.Size = new System.Drawing.Size(850, 39);
            this.lblWorkMonth.TabIndex = 2;
            this.lblWorkMonth.Tag = "";
            this.lblWorkMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWorkCount
            // 
            this.lblWorkCount.BackColor = System.Drawing.Color.White;
            this.lblWorkCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWorkCount.Font = new System.Drawing.Font("Tahoma", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWorkCount.Location = new System.Drawing.Point(959, 38);
            this.lblWorkCount.Name = "lblWorkCount";
            this.lblWorkCount.Size = new System.Drawing.Size(38, 50);
            this.lblWorkCount.TabIndex = 3;
            this.lblWorkCount.Text = "جمع کارکرد";
            this.lblWorkCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRestCount
            // 
            this.lblRestCount.BackColor = System.Drawing.Color.White;
            this.lblRestCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRestCount.Font = new System.Drawing.Font("Tahoma", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRestCount.Location = new System.Drawing.Point(996, 38);
            this.lblRestCount.Name = "lblRestCount";
            this.lblRestCount.Size = new System.Drawing.Size(38, 50);
            this.lblRestCount.TabIndex = 4;
            this.lblRestCount.Text = "جمع رست";
            this.lblRestCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeekDayTitle
            // 
            this.lblWeekDayTitle.BackColor = System.Drawing.Color.White;
            this.lblWeekDayTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeekDayTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblWeekDayTitle.Location = new System.Drawing.Point(0, 38);
            this.lblWeekDayTitle.Name = "lblWeekDayTitle";
            this.lblWeekDayTitle.Size = new System.Drawing.Size(185, 25);
            this.lblWeekDayTitle.TabIndex = 5;
            this.lblWeekDayTitle.Text = "روزهای هفته";
            this.lblWeekDayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRowTitle
            // 
            this.lblRowTitle.BackColor = System.Drawing.Color.White;
            this.lblRowTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRowTitle.Font = new System.Drawing.Font("Tahoma", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRowTitle.Location = new System.Drawing.Point(0, 63);
            this.lblRowTitle.Name = "lblRowTitle";
            this.lblRowTitle.Size = new System.Drawing.Size(25, 25);
            this.lblRowTitle.TabIndex = 6;
            this.lblRowTitle.Text = "ردیف";
            this.lblRowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.BackColor = System.Drawing.Color.White;
            this.lblNameTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNameTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNameTitle.Location = new System.Drawing.Point(24, 63);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(161, 25);
            this.lblNameTitle.TabIndex = 7;
            this.lblNameTitle.Text = "نام و نام خانوادگی";
            this.lblNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNext.Location = new System.Drawing.Point(356, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "ماه بعد";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrev.Location = new System.Drawing.Point(795, 8);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.Text = "ماه قبل";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // llblProfile
            // 
            this.llblProfile.AutoSize = true;
            this.llblProfile.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.llblProfile.LinkArea = new System.Windows.Forms.LinkArea(18, 10);
            this.llblProfile.Location = new System.Drawing.Point(842, 701);
            this.llblProfile.Name = "llblProfile";
            this.llblProfile.Size = new System.Drawing.Size(180, 19);
            this.llblProfile.TabIndex = 17;
            this.llblProfile.TabStop = true;
            this.llblProfile.Text = "Coded by ImTO1 -- @s_vahid_h";
            this.llblProfile.UseCompatibleTextRendering = true;
            this.llblProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblProfile_LinkClicked);
            // 
            // btnNow
            // 
            this.btnNow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNow.Location = new System.Drawing.Point(947, 8);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(75, 23);
            this.btnNow.TabIndex = 18;
            this.btnNow.Text = "ماه جاری";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // btnGoTo
            // 
            this.btnGoTo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGoTo.Location = new System.Drawing.Point(196, 8);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(75, 23);
            this.btnGoTo.TabIndex = 19;
            this.btnGoTo.Text = "برو به";
            this.btnGoTo.UseVisualStyleBackColor = true;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // btnAddPersonnel
            // 
            this.btnAddPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPersonnel.AutoSize = true;
            this.btnAddPersonnel.Location = new System.Drawing.Point(12, 691);
            this.btnAddPersonnel.Name = "btnAddPersonnel";
            this.btnAddPersonnel.Size = new System.Drawing.Size(152, 26);
            this.btnAddPersonnel.TabIndex = 20;
            this.btnAddPersonnel.Text = "اضافه کردن پرسنل";
            this.btnAddPersonnel.UseVisualStyleBackColor = true;
            this.btnAddPersonnel.Click += new System.EventHandler(this.btnAddPersonnel_Click);
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 729);
            this.Controls.Add(this.btnAddPersonnel);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.llblProfile);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblNameTitle);
            this.Controls.Add(this.lblRowTitle);
            this.Controls.Add(this.lblWeekDayTitle);
            this.Controls.Add(this.lblRestCount);
            this.Controls.Add(this.lblWorkCount);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblWorkMonth);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 768);
            this.MinimumSize = new System.Drawing.Size(1050, 768);
            this.Name = "TimeTable";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEHMERD TimeSheet";
            this.Load += new System.EventHandler(this.TimeTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblWorkMonth;
        private System.Windows.Forms.Label lblWorkCount;
        private System.Windows.Forms.Label lblRestCount;
        private System.Windows.Forms.Label lblWeekDayTitle;
        private System.Windows.Forms.Label lblRowTitle;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.LinkLabel llblProfile;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.Button btnAddPersonnel;
    }
}


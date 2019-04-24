namespace timesheet
{
    partial class frmEditPerson
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRest = new System.Windows.Forms.TextBox();
            this.lblRest = new System.Windows.Forms.Label();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.lblWork = new System.Windows.Forms.Label();
            this.lblRotation = new System.Windows.Forms.Label();
            this.cbRMonth = new System.Windows.Forms.ComboBox();
            this.txtRDay = new System.Windows.Forms.TextBox();
            this.txtRYear = new System.Windows.Forms.TextBox();
            this.lblRYear = new System.Windows.Forms.Label();
            this.lblRMonth = new System.Windows.Forms.Label();
            this.lblRDay = new System.Windows.Forms.Label();
            this.cbXP = new System.Windows.Forms.ComboBox();
            this.lblXP = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblToast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(327, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = ":نام و نام خانوادگی";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 15);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.MaxLength = 255;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtRest
            // 
            this.txtRest.Location = new System.Drawing.Point(318, 47);
            this.txtRest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRest.MaxLength = 2;
            this.txtRest.Name = "txtRest";
            this.txtRest.Size = new System.Drawing.Size(34, 23);
            this.txtRest.TabIndex = 2;
            this.txtRest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRest.TextChanged += new System.EventHandler(this.txtRest_TextChanged);
            // 
            // lblRest
            // 
            this.lblRest.AutoSize = true;
            this.lblRest.Location = new System.Drawing.Point(360, 50);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(82, 16);
            this.lblRest.TabIndex = 2;
            this.lblRest.Text = ":مرخصی(روز)";
            // 
            // txtWork
            // 
            this.txtWork.Location = new System.Drawing.Point(213, 47);
            this.txtWork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWork.MaxLength = 2;
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(34, 23);
            this.txtWork.TabIndex = 3;
            this.txtWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWork.TextChanged += new System.EventHandler(this.txtWork_TextChanged);
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.Location = new System.Drawing.Point(255, 50);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(53, 16);
            this.lblWork.TabIndex = 4;
            this.lblWork.Text = ":کار(روز)";
            // 
            // lblRotation
            // 
            this.lblRotation.AutoSize = true;
            this.lblRotation.Location = new System.Drawing.Point(352, 85);
            this.lblRotation.Name = "lblRotation";
            this.lblRotation.Size = new System.Drawing.Size(91, 16);
            this.lblRotation.TabIndex = 6;
            this.lblRotation.Text = ":شروع روتیشن";
            // 
            // cbRMonth
            // 
            this.cbRMonth.FormattingEnabled = true;
            this.cbRMonth.Items.AddRange(new object[] {
            "فروردین",
            "اردیبهشت",
            "خرداد",
            "تیر",
            "امرداد",
            "شهریور",
            "مهر",
            "آبان",
            "آذر",
            "دی",
            "بهمن",
            "اسپند"});
            this.cbRMonth.Location = new System.Drawing.Point(124, 81);
            this.cbRMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRMonth.Name = "cbRMonth";
            this.cbRMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbRMonth.Size = new System.Drawing.Size(112, 24);
            this.cbRMonth.TabIndex = 5;
            this.cbRMonth.SelectedIndexChanged += new System.EventHandler(this.cbRMonth_SelectedIndexChanged);
            // 
            // txtRDay
            // 
            this.txtRDay.Location = new System.Drawing.Point(276, 81);
            this.txtRDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRDay.MaxLength = 2;
            this.txtRDay.Name = "txtRDay";
            this.txtRDay.Size = new System.Drawing.Size(34, 23);
            this.txtRDay.TabIndex = 4;
            this.txtRDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRDay.TextChanged += new System.EventHandler(this.txtRDay_TextChanged);
            // 
            // txtRYear
            // 
            this.txtRYear.Location = new System.Drawing.Point(20, 81);
            this.txtRYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRYear.MaxLength = 4;
            this.txtRYear.Name = "txtRYear";
            this.txtRYear.Size = new System.Drawing.Size(58, 23);
            this.txtRYear.TabIndex = 6;
            this.txtRYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRYear.TextChanged += new System.EventHandler(this.txtRYear_TextChanged);
            // 
            // lblRYear
            // 
            this.lblRYear.AutoSize = true;
            this.lblRYear.Location = new System.Drawing.Point(85, 85);
            this.lblRYear.Name = "lblRYear";
            this.lblRYear.Size = new System.Drawing.Size(33, 16);
            this.lblRYear.TabIndex = 10;
            this.lblRYear.Text = "سال";
            // 
            // lblRMonth
            // 
            this.lblRMonth.AutoSize = true;
            this.lblRMonth.Location = new System.Drawing.Point(244, 85);
            this.lblRMonth.Name = "lblRMonth";
            this.lblRMonth.Size = new System.Drawing.Size(25, 16);
            this.lblRMonth.TabIndex = 11;
            this.lblRMonth.Text = "ماه";
            // 
            // lblRDay
            // 
            this.lblRDay.AutoSize = true;
            this.lblRDay.Location = new System.Drawing.Point(318, 85);
            this.lblRDay.Name = "lblRDay";
            this.lblRDay.Size = new System.Drawing.Size(23, 16);
            this.lblRDay.TabIndex = 12;
            this.lblRDay.Text = "روز";
            // 
            // cbXP
            // 
            this.cbXP.FormattingEnabled = true;
            this.cbXP.Location = new System.Drawing.Point(180, 114);
            this.cbXP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbXP.Name = "cbXP";
            this.cbXP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbXP.Size = new System.Drawing.Size(203, 24);
            this.cbXP.TabIndex = 7;
            this.cbXP.SelectedIndexChanged += new System.EventHandler(this.cbXP_SelectedIndexChanged);
            // 
            // lblXP
            // 
            this.lblXP.AutoSize = true;
            this.lblXP.Location = new System.Drawing.Point(392, 118);
            this.lblXP.Name = "lblXP";
            this.lblXP.Size = new System.Drawing.Size(51, 16);
            this.lblXP.TabIndex = 14;
            this.lblXP.Text = ":تخصص";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(346, 215);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 28);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(180, 215);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 28);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 215);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 28);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "تایید";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblToast
            // 
            this.lblToast.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblToast.Location = new System.Drawing.Point(0, 144);
            this.lblToast.Name = "lblToast";
            this.lblToast.Size = new System.Drawing.Size(449, 62);
            this.lblToast.TabIndex = 18;
            this.lblToast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToast.Visible = false;
            // 
            // frmEditPerson
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(448, 258);
            this.ControlBox = false;
            this.Controls.Add(this.lblToast);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblXP);
            this.Controls.Add(this.cbXP);
            this.Controls.Add(this.lblRDay);
            this.Controls.Add(this.lblRMonth);
            this.Controls.Add(this.lblRYear);
            this.Controls.Add(this.txtRYear);
            this.Controls.Add(this.txtRDay);
            this.Controls.Add(this.cbRMonth);
            this.Controls.Add(this.lblRotation);
            this.Controls.Add(this.txtWork);
            this.Controls.Add(this.lblWork);
            this.Controls.Add(this.txtRest);
            this.Controls.Add(this.lblRest);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEditPerson";
            this.ShowIcon = false;
            this.Text = "ویرایش پرسنل";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRest;
        private System.Windows.Forms.Label lblRest;
        private System.Windows.Forms.TextBox txtWork;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.Label lblRotation;
        private System.Windows.Forms.ComboBox cbRMonth;
        private System.Windows.Forms.TextBox txtRDay;
        private System.Windows.Forms.TextBox txtRYear;
        private System.Windows.Forms.Label lblRYear;
        private System.Windows.Forms.Label lblRMonth;
        private System.Windows.Forms.Label lblRDay;
        private System.Windows.Forms.ComboBox cbXP;
        private System.Windows.Forms.Label lblXP;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblToast;
    }
}
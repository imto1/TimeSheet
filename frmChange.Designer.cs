namespace timesheet
{
    partial class frmChange
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lblFromTitle = new System.Windows.Forms.Label();
            this.lblToTitle = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblStatusTo = new System.Windows.Forms.Label();
            this.Option1 = new System.Windows.Forms.RadioButton();
            this.Option2 = new System.Windows.Forms.RadioButton();
            this.lblToast = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.Option3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.Location = new System.Drawing.Point(197, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOK.Location = new System.Drawing.Point(12, 326);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "تایید";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(185, 63);
            this.txtFrom.MaxLength = 2;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(30, 23);
            this.txtFrom.TabIndex = 1;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // lblFromTitle
            // 
            this.lblFromTitle.AutoSize = true;
            this.lblFromTitle.Location = new System.Drawing.Point(221, 66);
            this.lblFromTitle.Name = "lblFromTitle";
            this.lblFromTitle.Size = new System.Drawing.Size(51, 16);
            this.lblFromTitle.TabIndex = 3;
            this.lblFromTitle.Text = ":از تاریخ";
            // 
            // lblToTitle
            // 
            this.lblToTitle.AutoSize = true;
            this.lblToTitle.Location = new System.Drawing.Point(221, 95);
            this.lblToTitle.Name = "lblToTitle";
            this.lblToTitle.Size = new System.Drawing.Size(51, 16);
            this.lblToTitle.TabIndex = 5;
            this.lblToTitle.Text = ":تا تاریخ";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(185, 92);
            this.txtTo.MaxLength = 2;
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(30, 23);
            this.txtTo.TabIndex = 2;
            this.txtTo.TextChanged += new System.EventHandler(this.txtTo_TextChanged);
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Location = new System.Drawing.Point(180, 123);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(92, 16);
            this.lblStatusTitle.TabIndex = 7;
            this.lblStatusTitle.Text = "وضعیت: تغییر از";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(234, 152);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(38, 16);
            this.lblReason.TabIndex = 9;
            this.lblReason.Text = ":علت";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(12, 149);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(203, 121);
            this.txtReason.TabIndex = 4;
            this.txtReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.Location = new System.Drawing.Point(-1, -1);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(287, 50);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFrom
            // 
            this.lblFrom.Location = new System.Drawing.Point(12, 66);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(167, 16);
            this.lblFrom.TabIndex = 11;
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTo
            // 
            this.lblTo.Location = new System.Drawing.Point(12, 95);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(167, 16);
            this.lblTo.TabIndex = 12;
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusTo
            // 
            this.lblStatusTo.AutoSize = true;
            this.lblStatusTo.Location = new System.Drawing.Point(111, 123);
            this.lblStatusTo.Name = "lblStatusTo";
            this.lblStatusTo.Size = new System.Drawing.Size(19, 16);
            this.lblStatusTo.TabIndex = 14;
            this.lblStatusTo.Text = "به";
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.Location = new System.Drawing.Point(67, 121);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(38, 20);
            this.Option1.TabIndex = 15;
            this.Option1.Text = "W";
            this.Option1.UseVisualStyleBackColor = true;
            this.Option1.CheckedChanged += new System.EventHandler(this.Option1_CheckedChanged);
            // 
            // Option2
            // 
            this.Option2.AutoSize = true;
            this.Option2.Location = new System.Drawing.Point(23, 121);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(38, 20);
            this.Option2.TabIndex = 16;
            this.Option2.Text = "W";
            this.Option2.UseVisualStyleBackColor = true;
            this.Option2.CheckedChanged += new System.EventHandler(this.Option2_CheckedChanged);
            // 
            // lblToast
            // 
            this.lblToast.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblToast.Location = new System.Drawing.Point(-1, 273);
            this.lblToast.Name = "lblToast";
            this.lblToast.Size = new System.Drawing.Size(287, 50);
            this.lblToast.TabIndex = 17;
            this.lblToast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToast.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(104, 326);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "حذف";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Option3
            // 
            this.Option3.AutoSize = true;
            this.Option3.Checked = true;
            this.Option3.Location = new System.Drawing.Point(136, 121);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(38, 20);
            this.Option3.TabIndex = 19;
            this.Option3.TabStop = true;
            this.Option3.Text = "W";
            this.Option3.UseVisualStyleBackColor = true;
            this.Option3.CheckedChanged += new System.EventHandler(this.Option3_CheckedChanged);
            // 
            // frmChange
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.ControlBox = false;
            this.Controls.Add(this.Option3);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblToast);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.lblStatusTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblStatusTitle);
            this.Controls.Add(this.lblToTitle);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblFromTitle);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(300, 400);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "frmChange";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت/ویرایش تغییرات";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lblFromTitle;
        private System.Windows.Forms.Label lblToTitle;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblStatusTo;
        private System.Windows.Forms.RadioButton Option1;
        private System.Windows.Forms.RadioButton Option2;
        private System.Windows.Forms.Label lblToast;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.RadioButton Option3;
    }
}
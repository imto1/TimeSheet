using System.Windows.Forms;

namespace timesheet
{
    public partial class frmGoTo : Form
    {
        public int year { get; set;}
        public int month { get; set;}

        public frmGoTo()
        {
            InitializeComponent();
        }
        public frmGoTo(int year, int month)
        {
            InitializeComponent();
            this.year = year;
            this.month = month;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            this.year = int.Parse(txtYear.Text);
            this.month = comboMonth.SelectedIndex + 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmGoTo_Load(object sender, System.EventArgs e)
        {
            txtYear.Text = year.ToString();
            comboMonth.SelectedIndex = month - 1;
        }
    }
}

using System;
using System.Windows.Forms;

namespace timesheet
{
    public partial class Master : Form
    {
        private int childFormNumber = 0;

        public Master()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void Master_Load(object sender, EventArgs e)
        {
            string[] version = Application.ProductVersion.ToString().Split('.');
            this.Text += " v" + version[0] + "." + version[1];
            TimeTable child = new TimeTable();
            child.MdiParent = this;
            child.Show();
        }
    }
}

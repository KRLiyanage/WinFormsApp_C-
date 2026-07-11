namespace StaffDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff Directory Pro v1.0\nCourse Code: CSCI 22042", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Visible = statusBarToolStripMenuItem.Checked;
        }
    }
}

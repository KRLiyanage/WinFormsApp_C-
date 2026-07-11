namespace StaffDirectory
{
    public partial class Form1 : Form
    {
        private IEnumerable<string> _staffEntries;

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

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using SaveFileDialog dlg = new()
            {
                Title = "Save Staff List",
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = "txt",
                FileName = "staff_list.txt"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SaveStaffToFile(dlg.FileName);
            }
        }

        private void SaveStaffToFile(string path)
        {
            try
            {
                File.WriteAllLines(path, _staffEntries);
                lblStatus.Text = $"Saved: {Path.GetFileName(path)}";
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

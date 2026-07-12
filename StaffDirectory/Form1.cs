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
            using OpenFileDialog dlg = new()
            {
                Title = "Open Staff List",
                Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadStaffFormFile(dlg.FileName);
            }
        }

        private void LoadStaffFormFile(string fileName)
        {
            throw new NotImplementedException();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyListClor();
            ApplyListFornt();
        }

        private void ApplyListFornt()
        {
            using ColorDialog dlg = new();
            dlg.Color = lstStaff.BackColor;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                lstStaff.BackColor = dlg.Color;
            }
        }

        private void ApplyListClor()
        {
            using FontDialog dlg = new();
            dlg.Font = lstStaff.Font;
            dlg.ShowEffects = false;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                lstStaff.Font = dlg.Font;
            }
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnToolbarAdd_Click(object sender, EventArgs e)
        {
            using AddStaffForm dlg = new AddStaffForm();

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string entry = BuildStaffEntry(dlg.EmployeeId, dlg.FullName, dlg.Emails, dlg.Department);

                //_staffEntries.Add(entry);
                lstStaff.Items.Add(entry);

                //lblStatus.Text = $"{_staffEntries.Count} staff record(s) on record.";
            }
        }

        private string BuildStaffEntry(string id, string name, string email, string dept)
        {
            return $"[{dept}] {id} — {name} — {email}"; 
        }

        private void Directory_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeColour_Click(object sender, EventArgs e)
        {
            using ColorDialog dlg = new ColorDialog();
            dlg.Color = lstStaff.BackColor;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                lstStaff.BackColor = dlg.Color;
            }
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            using FontDialog dlg = new FontDialog();
            dlg.Font = lstStaff.Font;
            dlg.ShowEffects = false;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                lstStaff.Font = dlg.Font;
            }
        }

        private void btnChangeBackground_Click(object sender, EventArgs e)
        {
            using ColorDialog dlg = new ColorDialog();
            dlg.Color = this.BackColor;

            if(dlg.ShowDialog() == DialogResult.OK )
            {
                this.BackColor = dlg.Color;
            }
        }
    }
}

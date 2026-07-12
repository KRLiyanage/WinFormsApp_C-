using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StaffDirectory
{
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
        }

        public string EmployeeId => txtEmployeeId.Text.Trim();
        public string FullName => txtFullName.Text.Trim();
        public string Emails => txtEmail.Text.Trim();
        public string Department => cmbDepartment.SelectedItem?.ToString() ?? "Unknown";
        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

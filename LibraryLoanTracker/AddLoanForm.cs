using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryLoanTracker
{
    public partial class AddLoanForm : Form
    {
        public string LoanId => txtLoanId.Text.Trim();
        public string BookTitle => txtBookTitle.Text.Trim();
        public string BorrowerName => txtBorrowerName.Text.Trim();
        public string BorrowerType => cmbBorrowerType.SelectedItem?.ToString()?? "Student";
        public DateTime LoanDate => dtpLoanDate.Value.Date;


        public AddLoanForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

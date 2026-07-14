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
        private bool isValid;

        public string LoanId => txtLoanId.Text.Trim();
        public string BookTitle => txtBookTitle.Text.Trim();
        public string BorrowerName => txtBorrowerName.Text.Trim();
        public string BorrowerType => cmbBorrowerType.SelectedItem?.ToString() ?? "Student";
        public DateTime LoanDate => dtpLoanDate.Value.Date;


        public AddLoanForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool isvalid = true;

            if(string.IsNullOrWhiteSpace(LoanId))
            {
                errorProvider1.SetError(txtLoanId, "Long ID cannot be Empty!");
                isvalid = false;
            }
            else
            {
                errorProvider1.SetError(txtLoanId, "");
            }

            if (string.IsNullOrWhiteSpace(BookTitle))
            {
                errorProvider1.SetError(txtBookTitle, "Book Title cannot be empty!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtBookTitle, "");
            }

           
            if (string.IsNullOrWhiteSpace(BorrowerName))
            {
                errorProvider1.SetError(txtBorrowerName, "Borrower Name cannot be empty!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtBorrowerName, "");
            }

            if (cmbBorrowerType.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbBorrowerType, "Please select a Borrower Type!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(cmbBorrowerType, "");
            }

            if (isValid)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}

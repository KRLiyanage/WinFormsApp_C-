using Microsoft.VisualBasic;
using System.Text.Json;

namespace LibraryLoanTracker
{
    public partial class Form1 : Form
    {

        private readonly List<LoanRecord> _loans = new();
        private readonly string _dataFilePath =
        Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.
        ApplicationData),
        "LibraryLoanTracker",
        "loans.json"
        );

        public Form1()
        {
            InitializeComponent();
        }

        private void btnToolbarNewLoan_Click(object sender, EventArgs e)
        {
            using (AddLoanForm dialog = new AddLoanForm())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    bool duplicate = _loans.Any(l => l.LoanId == dialog.LoanId);

                    if (duplicate)
                    {
                        MessageBox.Show("A loan with this ID already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var record = new LoanRecord
                    {
                        LoanId = dialog.LoanId,

                        BookTitle = dialog.BookTitle,

                        BorrowerName = dialog.BorrowerName,

                        BorrowerType = dialog.BorrowerType,

                        LoanDate = dialog.LoanDate,

                        DueDate = dialog.DueDate,

                        IsReturned = false
                    };

                    _loans.Add(record);

                    RefreshAllViews();
                }
            }
        }

        private void RefreshAllViews()
        {
            RefreshLoansList();
            RefreshOverdueList();
            RefreshSummary();
            UpdateStatusBar();
        }

        private void RefreshLoansList()
        {
            lstLoans.Items.Clear();

            foreach (var loan in _loans)
            {
                if (loan.IsReturned == false)
                {
                    lstLoans.Items.Add(loan.DisplayText);
                }
            }

            rtbLoanDetail.Clear();
        }

        private void RefreshOverdueList()
        {
            lstOverdue.Items.Clear();

            foreach (var loan in _loans)
            {
                if (loan.IsOverdue == true)
                {
                    lstOverdue.Items.Add(loan.DisplayText);
                }
            }
        }

        private void RefreshSummary()
        {
            int total = _loans.Count;
            int active = _loans.Count(l => !l.IsReturned);
            int returned = _loans.Count(l => l.IsReturned);
            int overdue = _loans.Count(l => l.IsOverdue);

            rtbSummary.Text = $"Total loans issued : {total}\n" +
                      $"Currently on loan   : {active}\n" +
                      $"Returned            : {returned}\n" +
                      $"Overdue             : {overdue}\n\n" +
                      "--- Overdue Records ---\n";

            foreach (var loan in _loans)
            {
                if (loan.IsOverdue)
                {
                    rtbSummary.AppendText(loan.DisplayText + " | OVERDUE\n");
                }
            }
        }

        private void UpdateStatusBar()
        {

            int active = _loans.Count(l => !l.IsReturned);
            int overdue = _loans.Count(l => l.IsOverdue);


            lblStatus.Text = $"{active} active loans | {overdue} overdue";
        }

        private void btnToolbarReturn_Click(object sender, EventArgs e)
        {
            if (lstLoans.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a loan from the list to mark as returned.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string selectedText = lstLoans.SelectedItem.ToString();
            string loanId = selectedText.Split('[', ']')[1];
            LoanRecord loan = _loans.FirstOrDefault(l => l.LoanId == loanId);

            if (loan != null)
            {

                if (!loan.IsReturned)
                {
                    loan.IsReturned = true;
                    RefreshAllViews();
                }
                else
                {

                    MessageBox.Show("This book has already been returned.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SaveToFile()
        {
            try
            {
                string dir = Path.GetDirectoryName(_dataFilePath)!;
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                string json = JsonSerializer.Serialize(_loans,
                new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_dataFilePath, json);
                lblStatus.Text = $"Saved--{_loans.Count} records";
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Save failed:\n{ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToolbarSave_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }
    }
}

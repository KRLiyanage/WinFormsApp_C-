using Microsoft.VisualBasic;

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
            using (AddLoanForm dialog  = new AddLoanForm())
            {
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    bool duplicate = _loans.Any(l=> l.LoanId == dialog.LoanId);

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
            throw new NotImplementedException();
        }
    }
}

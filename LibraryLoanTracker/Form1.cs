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
    }
}

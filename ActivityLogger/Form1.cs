using System.Text;

namespace ActivityLogger
{
    public partial class Form1 : Form
    {
        private List<WindowLogEntry> _log = new();
        private string _lastTitle = string .Empty;
        private DateTime _lastSwitchTime = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            IntPtr handle = NativeMethods.GetForegroundWindow();
            string currentTitle = string.Empty;

            if (handle != IntPtr.Zero)
            {
                StringBuilder sb = new StringBuilder(256);
                NativeMethods.GetWindowText(handle, sb, sb.Capacity);
                currentTitle = sb.ToString();
            }

           

            if (currentTitle != _lastTitle)
            {
                
                if (!string.IsNullOrEmpty(_lastTitle))
                {
                    int elapsedSeconds = (int)(DateTime.Now - _lastSwitchTime).TotalSeconds;

                    WindowLogEntry entry = new WindowLogEntry
                    {
                        WindowTitle = _lastTitle,
                        StartTime = _lastSwitchTime,
                        DurationSeconds = elapsedSeconds
                    };

                    _log.Add(entry);

                    
                    string formattedEntry = $"[{entry.StartTime:HH:mm:ss}] {entry.WindowTitle} ({entry.DurationSeconds}s)";
                    lstLog.Items.Add(formattedEntry);
                    lstLog.TopIndex = lstLog.Items.Count - 1;
                }

               
                _lastTitle = currentTitle;
                _lastSwitchTime = DateTime.Now;
            }
        }
    }
}

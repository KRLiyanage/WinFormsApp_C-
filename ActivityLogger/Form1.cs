using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ActivityLogger
{
    public partial class Form1 : Form
    {
        private List<WindowLogEntry> _log = new();
        private string _lastTitle = string.Empty;
        private DateTime _lastSwitchTime = DateTime.Now;

        public Form1()
        {
            InitializeComponent();

            // Saved Logs Load කර ගැනීම
            _log = StorageHelper.LoadLog();
            foreach (var entry in _log)
            {
                string formattedEntry = $"[{entry.StartTime:HH:mm:ss}] {entry.WindowTitle} ({entry.DurationSeconds}s)";
                lstLog.Items.Add(formattedEntry);
            }

            this.FormClosing += Form1_FormClosing;
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               
                if (!string.IsNullOrEmpty(_lastTitle))
                {
                    int elapsedSeconds = (int)(DateTime.Now - _lastSwitchTime).TotalSeconds;
                    _log.Add(new WindowLogEntry
                    {
                        WindowTitle = _lastTitle,
                        StartTime = _lastSwitchTime,
                        DurationSeconds = elapsedSeconds
                    });
                }

                StorageHelper.SaveLog(_log);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save logs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
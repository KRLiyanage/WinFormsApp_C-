using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityLogger
{
    public class WindowLogEntry
    {
        public string WindowTitle { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }

        public int DurationSeconds { get; set; }
    }
}

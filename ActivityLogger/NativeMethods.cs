using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace ActivityLogger
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X;
        public int Y;
    }

    public static class NativeMethods
    {
        
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern int GetWindowTextLength(IntPtr hWnd);

      
        private static void LogWin32Error(string methodName)
        {
            int errorCode = Marshal.GetLastWin32Error();
            if (errorCode != 0)
            {
                string logPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "ActivityLogger",
                    "win32_errors.log"
                );
                File.AppendAllText(logPath, $"[{DateTime.Now}] {methodName} failed with Win32 Error Code: {errorCode}{Environment.NewLine}");
            }
        }

        public static bool TryGetForegroundWindowTitle(out string title)
        {
            title = string.Empty;

            IntPtr handle = GetForegroundWindow();
            if (handle == IntPtr.Zero)
            {
                return false; 
            }

            StringBuilder sb = new StringBuilder(256);
            int result = GetWindowText(handle, sb, sb.Capacity);

            if (result == 0)
            {
               
                LogWin32Error("GetWindowText");
                return false;
            }

            title = sb.ToString();
            return true;
        }
    }
}
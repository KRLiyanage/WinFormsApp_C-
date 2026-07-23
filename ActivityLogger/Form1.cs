using System.Text;

namespace ActivityLogger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            IntPtr handle = NativeMethods.GetForegroundWindow();

            if(handle != IntPtr.Zero )
            {
                StringBuilder sb = new StringBuilder(256);

                NativeMethods.GetWindowText(handle,sb,sb.Capacity);

                lblCurrentWindow.Text = sb.ToString();
            }

        }
    }
}

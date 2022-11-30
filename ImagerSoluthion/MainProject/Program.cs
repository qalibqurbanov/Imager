using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            System.Threading.Mutex Mtx = new System.Threading.Mutex(true, "Imager", out bool Result);
            if (!Result)
            {
                MessageBox.Show("App Already Running", "Imager", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            GC.KeepAlive(Mtx);
        }
    }
}

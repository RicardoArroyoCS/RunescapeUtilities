using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nmz_notification
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TestSendWindowsToastMessage();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NmzForm());
        }

        private static void TestSendWindowsToastMessage()
        {
            NmzForm.SendWindowsToastMessage("Testing", "Woodcutting Alert");
        }
    }
}

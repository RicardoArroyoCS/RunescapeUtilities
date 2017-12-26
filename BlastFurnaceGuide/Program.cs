using BlastFurnaceGuide.Guides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlastFurnaceGuide
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BlastFurnaceGuideForm());

            //SteelBarsGuide guide = new SteelBarsGuide();

            //while(true)
            //{
            //    guide.NextStep();
            //    string Current = guide.ToString();
            //}
        }
    }
}

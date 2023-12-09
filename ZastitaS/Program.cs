using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZastitaS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Algoritam algoritam;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //algoritam = new XTea();
            Application.Run(/*new Form1(algoritam)*/ new OdabirForma());
        }
    }
}

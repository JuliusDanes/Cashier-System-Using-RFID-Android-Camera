using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGUI
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
            Application.Run(new AdminForm());
            
            // Form 1 = AdminForm atau SuperSU#
            // Form 2 = ProductDataForm
            // Form 3 = AddProForm
            // Form 4 = SearchProForm
            // Form 5 = UpdateProForm
            // Form 6 = ReportForm
        }
    }
}

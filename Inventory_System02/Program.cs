using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System02
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            bool createdNew;
            Mutex mutex = new Mutex(true, "YourApplicationName", out createdNew);
            if (!createdNew)
            {
                // Another instance is already running.
                // You can either show a message or bring the existing instance to the foreground.
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login1());
        }
    }
}

using Microsoft.Win32;
using System;
using System.Threading;
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

            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\codefilterPH\\InventoryMS");
            if (key == null)
            {
                // Registry key does not exist, create it
                Includes.MyInstaller.CreateRegistry();
            }
            Includes.AppSettings.My_path();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login1());
            Login1 loginForm = new Login1();
            loginForm.TopMost = true; // Set the form to be always on top
            loginForm.ShowDialog();

            mutex.ReleaseMutex();
        }
    }
}

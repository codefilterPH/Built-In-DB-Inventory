using Microsoft.Win32;
using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;

namespace Inventory_System02.Includes
{
    [RunInstaller(true)]
    public class MyInstaller : Installer
    {
        public override void Install(IDictionary savedState)
        {
            base.Install(savedState);
            if (Context.Parameters["installtype"] == "install")
            {
                CreateRegistry();
            }
        }

        public static void CreateRegistry()
        {
            // Get the current user's registry key
            RegistryKey key = Registry.CurrentUser;

            // Create a subkey for your application
            RegistryKey inventoryKey = key.CreateSubKey(@"Software\codefilterPH\InventoryMS");

            // Save the computer name as a string value
            inventoryKey.SetValue("ServerName", Environment.MachineName);

            // Save the common directory path as a string value
            inventoryKey.SetValue("CommonPath", @"\CommonSql\");


            // Save the invoice directory path as a string value
            string toolsDir = Path.Combine(inventoryKey.GetValue("CommonPath").ToString(), "Tools", "tools.dll");
            inventoryKey.SetValue("ToolsDir", toolsDir);

            // Save the image directory path as a string value
            string imageDir = Path.Combine(inventoryKey.GetValue("CommonPath").ToString(), "Pictures");
            inventoryKey.SetValue("ImageDir", imageDir);

            // Save the image directory path as a string value
            string reportsDir = Path.Combine(inventoryKey.GetValue("CommonPath").ToString(), "Reports Dir");
            inventoryKey.SetValue("ReportsDir", reportsDir);

            // Save the image directory path as a string value
            string documentDir = Path.Combine(inventoryKey.GetValue("CommonPath").ToString(), "Document Center Files");
            inventoryKey.SetValue("DocumentsDir", documentDir);


            // Save the invoice directory path as a string value
            string invoiceDir = Path.Combine(inventoryKey.GetValue("CommonPath").ToString(), "Invoice");
            inventoryKey.SetValue("InvoiceDir", invoiceDir);
        }
    }

    internal class CreateRegistry
    {
        public static void AddToRegistry()
        {
            // Get the current user's registry key
            RegistryKey key = Registry.CurrentUser;

            // Create a subkey for your application
            RegistryKey subkey = key.CreateSubKey("Software\\codefilterPH\\InventoryMS");

            // Save the computer name as a string value
            subkey.SetValue("ServerName", "localhost");
        }
    }
}

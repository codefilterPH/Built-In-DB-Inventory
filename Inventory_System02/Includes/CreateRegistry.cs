using System.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Runtime.Remoting.Contexts;
using Microsoft.Win32;

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

        private static void CreateRegistry()
        {
            // Get the current user's registry key
            RegistryKey key = Registry.CurrentUser;

            // Create a subkey for your application
            RegistryKey subkey = key.CreateSubKey("Software\\codefilterPH\\InventoryMS");

            // Save the computer name as a string value
            subkey.SetValue("ServerName", Environment.MachineName);
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

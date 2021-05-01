using System;
using System.Threading;

namespace Stealer.Modules
{
    class AppMutex
    {
        // Check mutex
        public static void Check()
        {
            bool createdNew = false;
            // Check
            Mutex currentApp = new Mutex(false, config.mutex, out createdNew);
            if (!createdNew)
                Environment.Exit(1);
        }
    }
}

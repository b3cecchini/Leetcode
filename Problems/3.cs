using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _3
    {
       

        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> h = new();
            int max = 0;

            // "dvdf"

            foreach (var c in s)
            {
                if (h.Contains(c))
                {
                    max = Math.Max(max, h.Count);
                    h = new();
                }
                h.Add(c);
            }

            return Math.Max(max, h.Count);
        }

    }
}

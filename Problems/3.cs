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
            int l = 0;
            int max = 0;

            // "dvdf"

            for (int r = 0; r < s.Length; r++)
            {
                while (h.Contains(s[r]))
                {
                    h.Remove(s[l]);
                    l++;
                }

                h.Add(s[r]);
                max = Math.Max(max, r - l + 1);
            }

            return max;
        }

    }
}

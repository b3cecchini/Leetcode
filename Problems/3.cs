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
            int count = 0;


            //  "dvdf"
            //    d
            //  h: [d]

            // count 1
            // max: 0


            foreach (var c in s)
            {
                if (h.Contains(c))
                {
                    h = new();
                    max = Math.Max(max, count);
                    count = 1;
                }
                else count++;
                h.Add(c);
            }

            return Math.Max(max, count);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _3185
    {
        public long CountCompleteDayPairs(int[] hours)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            long count = 0;

            foreach (int hour in hours)
            {
                int r = hour % 24;
                int c = (24 - r) % 24;

                if (dict.ContainsKey(c)) count += dict[c];
                if (dict.ContainsKey(r)) dict[r]++;
                else dict.Add(r, 1);
            }
            
            return count;
        }
    }
}
    


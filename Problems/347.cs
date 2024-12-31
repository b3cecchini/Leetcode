using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _347
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (var c in nums)
            {
                if (counts.ContainsKey(c)) counts[c]++;
                else counts[c] = 1;
            }

            return counts.OrderByDescending(pair => pair.Value).Select(pair => pair.Key).Take(k).ToArray();
        }
    }
}

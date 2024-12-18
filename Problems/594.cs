using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _594
    {
        public int FindLHS(int[] nums)
        {
            int max = 0;
            HashSet<int> tried = new HashSet<int>();
            foreach (var x in nums)
            {
                if(!tried.Contains(x) && nums.Contains(x+1))
                {
                    max = Math.Max(max, nums.Count(a => a == x || a == x + 1));
                }
                tried.Add(x);
            }

            return max;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _747
    {
        public int DominantIndex(int[] nums)
        {
            var numSet = nums.ToHashSet();
            var max = numSet.Max();
            numSet.Remove(max);
            var nextMax = numSet.Max();
            if(nextMax == 0 || max / nextMax >= 2) return Array.IndexOf(nums, max);
            return -1;
        }
    }
}

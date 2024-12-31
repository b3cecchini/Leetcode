using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _2956
    {
        public int[] FindIntersectionValues(int[] nums1, int[] nums2)
        {
            int val1 = 0, val2 = 0;

            foreach (int i in nums1) if (nums2.Contains(i)) val1++;

            foreach (int i in nums2) if (nums1.Contains(i)) val2++;

            return [val1, val2];
        }
    }
}

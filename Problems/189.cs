using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Leetcode.Problems
{
    public class _189
    {
        public void Rotate(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return;

            int length = nums.Length;
            k = k % length;
            if (k == 0)
                return;

            Array.Reverse(nums, 0, length);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, length - k);
        }
    }
}

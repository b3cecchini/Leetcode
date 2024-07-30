using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Utils;

namespace Leetcode.Problems
{
    public class _108
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return Sort(nums, 0, nums.Length - 1);
        }
        // [-10, -3, 0, 5, 9]
        private TreeNode Sort(int[] nums, int start, int end)
        {
            if (start > end) { return null; }
            int mid = start + (end - start) / 2;
            
            return new TreeNode(nums[mid], Sort(nums, start, mid - 1), Sort(nums, mid + 1, end));
        }
    }
}

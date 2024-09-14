using Leetcode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _112
    {
        int depthCount = 0;
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            
            if(root != null)
            {
                if (root.left == null && root.right == null && root.val == targetSum) { return true; }
                if (root.val == targetSum && depthCount != 0) return true;
                this.depthCount++;
                return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
            }
            return false;
        }
    }
}

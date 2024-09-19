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
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            
            if (isEnd(root) && targetSum - root.val == 0) return true;
           
            return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
            
        }


        /*
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root != null)
            {
                if (root.val == targetSum && (root.left != null || root.right != null)) { return false; }
                if (root.left == null && root.right == null && root.val == targetSum) { return true; }
                if (root.val == targetSum && depthCount != 0) return true;
                this.depthCount++;
                if (root.right != null && root.val + root.right.val == targetSum && isEnd(root.right)) return true;
                if (root.left != null && root.val + root.left.val == targetSum && isEnd(root.left)) return true;
                
                return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
            }
            return false;
        }*/

        private bool isEnd(TreeNode root)
        {
            return root.left == null && root.right == null;
        }
    }
}

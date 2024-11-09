using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Utils;

namespace Leetcode.Problems
{
    public class _99
    {
        public void RecoverTree(TreeNode root)
        {
            if (root == null) return;
            if(dfs(root).val > root.val)
            {

            };
        }

        private TreeNode dfs(TreeNode root)
        {
            if (root == null) return null;
            if(dfs(root.left) != null && root.left.val > root.val) 
            {
                int temp = root.val;
                root.val = root.left.val;
                root.left.val = temp;
            }
        }
    }
}

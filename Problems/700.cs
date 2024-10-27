using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Utils;

namespace Leetcode.Problems
{
    public class _700
    {
        public int target;
        public TreeNode answer = null;
        public TreeNode SearchBST(TreeNode root, int val)
        {
            target = val;
            dfs(root);
            return answer;
        }

        private void dfs(TreeNode root)
        {
            if (root != null)
            {
                if(root.val == target) { answer = root; }
                dfs(root.left);
                dfs(root.right);
            }
            return;
        }
    }
}

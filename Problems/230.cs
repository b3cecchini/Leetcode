using Leetcode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _230
    {
        private int k;
        private int? result;

        public int KthSmallest(TreeNode root, int k)
        {
            this.k = k;
            this.result = null;

            Inorder(root);
            return result ?? -1;
        }

        private void Inorder(TreeNode node)
        {
            if (node == null || result.HasValue)
            {
                return;
            }

            Inorder(node.left);

            k--;
            if (k == 0)
            {
                result = node.val;
                return;
            }

            Inorder(node.right);
        }
    }
}

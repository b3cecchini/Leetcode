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
            if (root.left != null)
            {
                if(root.left.val > root.val)
                {
                    int temp = root.val;
                    root.val = root.left.val;
                    root.left.val = temp;
                    return;
                }
                RecoverTree(root.left);
            }

            if (root.right != null)
            {
                if (root.right.val < root.val)
                {
                    int temp = root.val;
                    root.val = root.right.val;
                    root.right.val = temp;
                    return;
                }
                RecoverTree(root.right);
            }
        }
    }
}

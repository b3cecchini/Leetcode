using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Utils;

namespace Leetcode.Problems
{
    public  class _98
    {
        /*
                   5 
        *         /  \
        *        1   4 
        *           /  \
        *          3    6
        *          
        *      
        */
        List<int> vals = new List<int>();

        public bool IsValidBST(TreeNode root)
        {
            inOrder(root);

            for (int i = 0; i < vals.Count - 1; i++)
            {
                if(vals[i+1] <= vals[i]) return false;
            }
            return true;
        }

        private void inOrder(TreeNode root)
        {
            if (root == null) return;

            if (root.left != null) inOrder(root.left);

            vals.Add(root.val);

            if(root.right  != null) inOrder(root.right);
        }
    }
}

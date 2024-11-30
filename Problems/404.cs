using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Utils;

namespace Leetcode.Problems
{
    public class _404
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();

            stack.Push(root);
            int total = 0;
            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                if(node.left != null) 
                {
                    if (node.left.left == null && node.left.right == null)
                    {
                        total += node.left.val;
                    }
                    else
                    {
                        stack.Push(node.left);
                    } 
                }
                if(node.right != null) { stack.Push(node.right); }
            }
           
            return total;

        }

       
    }
}

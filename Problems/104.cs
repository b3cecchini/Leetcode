using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Utils;

namespace Leetcode.Problems
{
    public class _104
    {
        public int MaxDepth(TreeNode root)
        {
            var count = 0;
            if (root != null)
            {
                return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
            }

            return count;
            
            
        }
    }
}

using Leetcode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _145
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var ans = new List<int>();
            if(root != null)
            {
                if (root.left != null) ans.AddRange(PostorderTraversal(root.left));
                if (root.right != null) ans.AddRange(PostorderTraversal(root.right));
                ans.Add(root.val);
            }

            return ans;
        }
    }
}

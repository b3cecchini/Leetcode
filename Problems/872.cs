using Leetcode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _872
    {
        public List<int> leftLeafs = new();
        public List<int> rightLeafs = new();
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            dfs(root1, "left");
            dfs(root2, "right");

            if (leftLeafs.Count != rightLeafs.Count) return false;

            for(int i = 0; i < leftLeafs.Count; i++)
            {
                if (leftLeafs[i] != rightLeafs[i]) return false;
            }

            return true;
        }
        
        private void dfs(TreeNode root, string leftRight)
        {
            if(root != null)
            {
                if(root.left == null && root.right == null) 
                {
                    if(leftRight == "left") { leftLeafs.Add(root.val); }
                    else { rightLeafs.Add(root.val); }
                }
                dfs(root.left, leftRight);
                dfs(root.right, leftRight);
            }
        }
    }
}

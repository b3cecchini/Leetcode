using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Utils;

namespace Leetcode.Problems
{
    public class _94
    {
        List<int> answer = new List<int>();

        public IList<int> InorderTraversal(TreeNode root)
        {

            if (root == null) return new List<int>();

            InorderTraversal(root.left);
            answer.Add(root.val);
            InorderTraversal(root.right);

            return answer;
        }
    }
}

using Leetcode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _1161
    {
        public int MaxLevelSum(TreeNode root)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            if (root == null) return 0;
            Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();
            int level = 1;
            queue.Enqueue((root, level));
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (dict.ContainsKey(node.Item2)) dict[node.Item2].Add(node.Item1.val);
                else dict[node.Item2] = new List<int>() { node.Item1.val };
                if (node.Item1.left != null) queue.Enqueue((node.Item1.left, node.Item2 + 1));
                if (node.Item1.right != null) queue.Enqueue((node.Item1.right, node.Item2 + 1));
                level++;
            }

            var ans = int.MinValue;
            var bestSum = int.MinValue;
            foreach (var item in dict)
            {
                List<int> list = [.. item.Value];
                if (list.Sum() > bestSum)
                {
                    bestSum = list.Sum();
                    ans = item.Key;
                }
            }
            return ans;
        }
    }
}

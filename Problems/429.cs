using Leetcode.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _429
    {
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> ans;

            Queue<(Node, int)> queue = new();
            int level = 0;

            queue.Enqueue((root, level));

            while (queue.Count > 0)
            {
                var t = queue.Dequeue();
                var node = t.Item1 as Node;
                level = t.Item2;

                if (node != null)
                {

                    if (dict.ContainsKey(level))
                    {
                        dict[level].Add(node.val);
                    }
                    else
                    {
                        dict[level] = new List<int>() { node.val };
                    }

                    if (node.children.Any())
                    {
                        foreach (var child in node.children)
                        {
                            queue.Enqueue((child, level + 1));
                        }
                    }
                }
                
            }

            ans = new List<IList<int>>();

            foreach(var k in dict.Keys)
            {
                var levelAns = new List<int>();
                foreach(var v in dict[k])
                {
                    levelAns.Add(v);
                }
                ans.Add(levelAns);

            }

            return ans;

        }
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _754
    {
        public int ReachNumber(int target)
        {
            var num = Math.Abs(target); 

            int count = 0;
            int sum = 0;

            while (sum < num || (sum - num) % 2 != 0)
            {
                count++;
                sum += count;
            }

            return count;
        }
        public int ReachNumber_2(int target)
        {
            HashSet<int> visited = new HashSet<int>();

            Queue<(int, int)> queue = new Queue<(int, int)>();

            queue.Enqueue((0, 0));
            (int, int) curr;
            while (queue.Count != 0)
            {
                curr = queue.Dequeue();
                if (curr.Item1 == target) return curr.Item2;
                if(!visited.Contains(curr.Item1)) 
                {
                    queue.Enqueue((curr.Item1 + (curr.Item2 + 1), curr.Item2 + 1));
                    queue.Enqueue((curr.Item1 - (curr.Item2 + 1), curr.Item2 + 1)); 
                    visited.Add(curr.Item1);
                    visited.Add(curr.Item1 + (curr.Item2 + 1));
                    visited.Add(curr.Item1 - (curr.Item2 + 1));
                }
            }
            return 0;
        }
    }
}

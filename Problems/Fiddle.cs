using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Utils;

namespace Leetcode.Problems
{
    public  class Fiddle
    {
        public List<int> answer = new List<int>();

        public void ResetAnswer()
        {
            this.answer = new List<int>();
        }

        public void DepthFirstSearch(TreeNode root)
        {
            if (root != null)
            {
                DepthFirstSearch(root.left);
                DepthFirstSearch(root.right);

                answer.Add(root.val);
            }

            return;
        }

        public List<int> DepthFirst_WithStack(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            List<int> ans = new List<int>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                ans.Add(current.val);
                if (current.right != null)
                {
                    stack.Push(current.right);
                }
                if (current.left != null) 
                {
                    stack.Push(current.left);
                }
            }
            return ans;
        }

        public List<int> BreathFirst_WithQueue(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            List<int> ans = new List<int>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                ans.Add(current.val);
                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }
                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }
            return ans;
        } 
        
           /*
            *       0
            *     /   \ 
            *    1     2 
            *   / \     \
            *  3   4     5
            *           /
            *          6
            */

        public bool TreeIncludes_Iterative(TreeNode root, int target)
        {
            if (root == null) return false;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                var current = q.Dequeue();
                if (current.val == target) { return true; }

                if(current.left != null){q.Enqueue(current.left);}
                if(current.right != null){q.Enqueue(current.right);}
            }
            return false;
        }

        public bool TreeIncludes_Recursive(TreeNode root, int target)
        {
            if (root == null) return false;
            if (root.val == target) return true;
            return TreeIncludes_Recursive(root.left, target) || TreeIncludes_Recursive(root.right, target);
        }

        public int TreeSum_Recursive(TreeNode root)
        {
            if (root == null) return 0;
            return root.val + TreeSum_Recursive(root.left) + TreeSum_Recursive(root.right);
        }

        // Consume Values when you LEAVE the queue, not when entering the queue ****
        public int TreeSum_Itterative(TreeNode root)
        {
            int total = 0;
            if (root != null)
            {
                Queue<TreeNode> q = new Queue<TreeNode>();
                q.Enqueue(root);
                while (q.Count > 0)
                {
                    var current = q.Dequeue();
                    total += current.val;
                    if (current.left != null) { q.Enqueue(current.left); }
                    if (current.right != null) { q.Enqueue(current.right); }
                }
            }
            return total;
        }

        public int TreeMin_Itterative(TreeNode root)
        {
            int min = root.val;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                var current = q.Dequeue();
                if(min > current.val) min = current.val;
                if (current.left != null) { q.Enqueue(current.left); }
                if (current.right != null) { q.Enqueue(current.right); }
            }
            
            return min;
        }

        public int TreeMin_Recursive(TreeNode root)
        {
            if(root == null) return int.MaxValue;
            var leftMin = TreeMin_Recursive(root.left);
            var rightMin = TreeMin_Recursive(root.right);
            return Math.Min(root.val, Math.Min(leftMin, rightMin));
        }

        public int TreeMaxSum_Recursive(TreeNode root)
        {
            if (root == null) return int.MinValue;
            if (root.left == null && root.right == null) return root.val;
            var maxChild = Math.Max(TreeMaxSum_Recursive(root.left), TreeMaxSum_Recursive(root.right));
            return root.val + maxChild;
        }

        public void PrintTreeByLevel(TreeNode root)
        {
            Dictionary<int, List<int>> d = new Dictionary<int, List<int>>();

            Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();

            queue.Enqueue((root, 1));

            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();

                if(d.ContainsKey(curr.Item2))
                {
                    d[curr.Item2].Add(curr.Item1.val);
                }
                else
                {
                    d[curr.Item2] = new List<int>() { curr.Item1.val};
                }

                if (curr.Item1.left != null) { queue.Enqueue((curr.Item1.left, curr.Item2 + 1)); }
                if (curr.Item1.right != null) { queue.Enqueue((curr.Item1.right, curr.Item2 + 1)); }
            }


            // counts.OrderByDescending(pair => pair.Value).Select(pair => pair.Key).Take(k).ToArray();
            foreach (var entry in d.OrderBy(pair => pair.Key).Select(pair => pair.Value))
            {
                foreach (var value in entry) 
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }

        }





    }
}

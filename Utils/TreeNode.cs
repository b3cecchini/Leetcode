using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Utils
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class TreePrinter
    {
        public static void PrintTree(TreeNode root, string indent = "", bool isLeft = false)
        {
            if (root == null)
                return;

            Console.WriteLine($"{indent}├── {root.val}");

            // Create new indent for children
            indent += isLeft ? "│   " : "    ";

            // Process children
            PrintTree(root.left, indent, true);
            PrintTree(root.right, indent, false);
        }
    }

}

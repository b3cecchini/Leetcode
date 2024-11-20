using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Leetcode.Utils;

namespace Leetcode.Problems
{
    public class _164
    {
        public int MaximumGap(int[] nums)
        {
            var maxDiff = 0;
            if(nums.Length > 1)
            {
                var bst = BinarySearchTree.CreateFromArray(nums);

                Console.WriteLine("Inorder traversal of the created BST:");
                var inorderResult = bst.InorderTraversal();
                for (int i = 1; i < inorderResult.Count; i++)
                {
                    maxDiff = Math.Max(maxDiff, inorderResult[i] - inorderResult[i - 1]);
                }

            }
            return maxDiff;
            
        }
    }
}

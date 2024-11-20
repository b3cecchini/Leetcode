using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Utils
{
    public class BinarySearchTree
    {
        private TreeNode root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int val)
        {
            root = InsertRecursive(root, val);
        }

        private TreeNode InsertRecursive(TreeNode TreeNode, int val)
        {
            if (TreeNode == null)
            {
                return new TreeNode(val);
            }

            if (val < TreeNode.val)
            {
                TreeNode.left = InsertRecursive(TreeNode.left, val);
            }
            else
            {
                TreeNode.right = InsertRecursive(TreeNode.right, val);
            }

            return TreeNode;
        }

        public List<int> InorderTraversal()
        {
            var result = new List<int>();
            InorderRecursive(root, result);
            return result;
        }

        private void InorderRecursive(TreeNode TreeNode, List<int> result)
        {
            if (TreeNode != null)
            {
                InorderRecursive(TreeNode.left, result);
                result.Add(TreeNode.val);
                InorderRecursive(TreeNode.right, result);
            }
        }

        public static BinarySearchTree CreateFromArray(int[] array)
        {
            var bst = new BinarySearchTree();
            foreach (var val in array)
            {
                bst.Insert(val);
            }
            return bst;
        }
    }
}

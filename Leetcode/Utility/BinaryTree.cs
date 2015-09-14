using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Utility
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class BinaryTree
    {
        public static TreeNode CreateBinaryTree(int[] values)
        {
            TreeNode root = new TreeNode(values[0]);
            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            nodeQueue.Enqueue(root);

            TreeNode current = null;

            foreach (var value in values.Skip(1))
            {
                if (current == null || (current.left != null && current.right != null))
                    current = nodeQueue.Dequeue();
                TreeNode node = new TreeNode(value);
                if (current.left == null)
                {
                    current.left = node;
                    nodeQueue.Enqueue(current.left);
                }
                else if (current.right == null)
                {
                    current.right = node;
                    nodeQueue.Enqueue(current.right);
                }
            }

            return RemoveNegativeNode(root);
            //return root;
        }

        public static TreeNode RemoveNegativeNode(TreeNode root)
        {
            if (root.val == -1)
                return null;

            Visit(root);
            return root;
        }

        private static void Visit(TreeNode root)
        {
            if (root == null)
                return;
            if (root.left != null && root.left.val == -1)
                root.left = null;
            if (root.right != null && root.right.val == -1)
                root.right = null;

            Visit(root.left);
            Visit(root.right);
        }
    }
}

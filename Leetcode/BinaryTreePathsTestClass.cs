using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Leetcode
{
    [TestFixture]
    [Category("BinaryTreePaths")]
    public class BinaryTreePathsTestClass
    {
        static object[] case1 = {
                                    new object[] {
                                        new TreeNode(1) { left = new TreeNode(2) { right = new TreeNode(5) }, right = new TreeNode(3) }, 
                                        new List<string>() { "1->2->5", "1->3" }
                                    },
                                    new object[] {
                                        null, 
                                        new List<string>()
                                    }

                                };
        [Test]
        [TestCaseSource("case1")]
        public void BinaryTreePathsTest(TreeNode root, List<string> expect)
        {
            List<string> result = BinaryTreePaths(root);
            Assert.AreEqual(expect, result);
        }

        private List<string> BinaryTreePaths(TreeNode root)
        {
            if (root == null)
                return new List<string>();
            StringBuilder sb = new StringBuilder();
            List<string> result = new List<string>();
            Visit(root, sb.ToString(), result);
            return result;
        }

        private void Visit(TreeNode treeNode, string current, List<string> result)
        {
            StringBuilder sb = new StringBuilder(current);

            if (treeNode != null)
            {
                if (!string.IsNullOrEmpty(current))
                    sb.Append("->");
                sb.Append(treeNode.val.ToString());
            }

            if (treeNode.left == null && treeNode.right == null)
                result.Add(sb.ToString());

            if (treeNode.left != null)
            {
                Visit(treeNode.left, sb.ToString(), result);
            }
            if (treeNode.right != null)
            {
                Visit(treeNode.right, sb.ToString(), result);
            }
        }
    }

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}

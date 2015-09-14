using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Leetcode.Utility;

namespace Leetcode
{
    [TestFixture]
    [Category("PathSumII")]
    public class PathSumIITestClass
    {
        static object[] case1 = {
                                    new object[] {
                                        BinaryTree.CreateBinaryTree(new int[] { 5, 4, 8, 11, -1, 13, 4, 7, 2, -1, -1, -1, -1, 5, 1 }), 
                                        22,
                                        new List<List<int>>() { new List<int>{ 5,4,11,2}, new List<int>{5,8,4,5}}
                                    },
                                };

        [Test]
        [TestCaseSource("case1")]
        public void PathSumIITest(TreeNode root, int sum, List<string> expect)
        {
            IList<IList<int>> result = PathSum(root, sum);
            Assert.AreEqual(expect, result);
        }

        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            throw new NotImplementedException();
        }

    }
}

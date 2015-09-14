using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Leetcode.Utility
{
    [TestFixture]
    public class BinaryTreeTest
    {
        [Test]
        public void CreateCompleteBinaryTreeTest()
        {
            //var result = BinaryTree.CreateCompleteBinaryTree(new int[] { 5, 4, 8, 11, -1, 13, 4, 7, 2, -1, -1, -1, -1, 5, 1 });
            var result = BinaryTree.CreateBinaryTree(new int[] { 5, 4, 8, 11, -1, 13, 4, 7, 2, -1, -1, -1, -1, 5, 1 });
            Assert.IsNotNull(result);
        }

    }
}

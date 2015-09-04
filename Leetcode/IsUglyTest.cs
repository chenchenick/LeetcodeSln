using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Leetcode
{
    [TestFixture]
    [Category("IsUgly")]
    public class IsUglyTest
    {
        [Test]
        [TestCase(1,true)]
        [TestCase(6, true)]
        [TestCase(8, true)]
        [TestCase(14, false)]
        public void IsUgly_Test(int num, bool espected)
        {
            bool result = IsUgly(num);
            Assert.AreEqual(espected, result);
        }

        private bool IsUgly(int num)
        {
            if (num <= 0)
                return false;
            if (num == 1)
                return true;
            if (num % 2 == 0)
                return IsUgly(num / 2);
            else if (num % 3 == 0)
                return IsUgly(num / 3);
            else if (num % 5 == 0)
                return IsUgly(num / 5);
            else
                return false;
        }
    }
}

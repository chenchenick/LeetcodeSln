using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Leetcode
{
    [TestFixture]
    [Category("AddDigits")]
    public class AddDigitsTestClass
    {
        [Test]
        [TestCase(38, 2)]
        [TestCase(101, 2)]
        public void AddDigitsTest(int num, int expect)
        {
            int result = AddDigits(num);
            Assert.AreEqual(expect, result);
        }

        private int AddDigits_Reference(int num)
        {
            return 1 + (num - 1) % 9;
        }

        private int AddDigits(int num)
        {
            int sum = 0;
            int digit = 0;
            do
            {
                digit = num % 10;
                sum += digit;
                num = num / 10;
            } while (num >= 10);

            sum += num;
            if (sum >= 10)
                return AddDigits(sum);
            else
                return sum;
        }
    }
}

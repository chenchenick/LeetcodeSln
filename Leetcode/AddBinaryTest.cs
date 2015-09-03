using System;
using NUnit.Framework;

namespace Leetcode
{
    [TestFixture]
    public class AddBinaryTest
    {
        [Test]
        [TestCase("0", "0", "0")]
        [TestCase("0", "1", "1")]
        [TestCase("11", "1", "100")]
        public void TestMethod1(string a, string b, string expect)
        {
            string result = AddBinary(a, b);
            Assert.AreEqual(expect, result);
        }

        public string AddBinary(string a, string b)
        {
            if (b.Length > a.Length)
            {
                string temp = a;
                a = b;
                b = temp;
            }
            string resultStr = string.Empty;
            int carry = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                int intA = Convert.ToInt32(a.Substring(i, 1));
                if (b.Length > 0)
                {
                    int intB = Convert.ToInt32(b.Substring(b.Length - 1, 1));
                    b = b.Substring(0, b.Length - 1);
                    SumBit(ref resultStr, ref carry, intA, intB);
                }
                else
                {
                    SumBit(ref resultStr, ref carry, intA, 0);
                }
            }

            if (carry == 1)
                resultStr = resultStr.Insert(0, "1");

            return resultStr;
        }

        private static void SumBit(ref string resultStr, ref int carry, int intA, int intB)
        {
            int sum = intA + intB + carry;
            carry = sum / 2;
            int resultInt = sum % 2;
            resultStr = resultStr.Insert(0, resultInt.ToString());
        }
    }
}

using System;
using NUnit.Framework;
using System.Text;

namespace Leetcode
{
    [TestFixture]
    [Category("AddBinary")]
    public class AddBinaryTestClass
    {
        [Test]
        [TestCase("0", "0", "0")]
        [TestCase("0", "1", "1")]
        [TestCase("11", "1", "100")]
        public void TestMethod1(string a, string b, string expect)
        {
            string result = AddBinary_Referece(a, b);
            Assert.AreEqual(expect, result);
        }
        public string AddBinary_Referece(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int carry = 0;
            for (int i = a.Length - 1, j = b.Length - 1; i >= 0 || j >= 0; i--, j--)
            {
                int intA = i >= 0 ? a[i] - '0' : 0;
                int intB = j >= 0 ? b[j] - '0' : 0;
                int sum = intA + intB + carry;
                carry = sum / 2;
                sb.Insert(0, (sum % 2).ToString());
            }

            if (carry == 1)
                sb.Insert(0, "1");

            return sb.ToString();
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

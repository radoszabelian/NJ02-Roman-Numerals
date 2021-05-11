using Microsoft.VisualStudio.TestTools.UnitTesting;
using NJ02_Roman_Numerals;

namespace Roman_Numerals___Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test0()
        {
            int x = 0;
            string result = x.ConvertToRomanNumber();

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void Test7()
        {
            int x = 7;
            string result = x.ConvertToRomanNumber();

            Assert.AreEqual("VII", result);
        }

        [TestMethod]
        public void Test32()
        {
            int x = 32;
            string result = x.ConvertToRomanNumber();

            Assert.AreEqual("XXXII", result);
        }

        [TestMethod]
        public void Test67()
        {
            int x = 67;
            string result = x.ConvertToRomanNumber();

            Assert.AreEqual("LXVII", result);
        }

        [TestMethod]
        public void Test89()
        {
            int x = 89;
            string result = x.ConvertToRomanNumber();

            Assert.AreEqual("LXXXIX", result);
        }

        [TestMethod]
        public void Test153()
        {
            int x = 153;
            string result = x.ConvertToRomanNumber();

            Assert.AreEqual("CLIII", result);
        }

        [TestMethod]
        public void Test777()
        {
            int x = 777;
            string result = x.ConvertToRomanNumber();

            Assert.AreEqual("DCCLXXVII", result);
        }

        [TestMethod]
        public void Test1255()
        {
            int x = 1255;
            string result = x.ConvertToRomanNumber();

            Assert.AreEqual("MCCLV", result);
        }

        [TestMethod]
        public void Test1725()
        {
            int x = 1725;
            string result = x.ConvertToRomanNumber();

            Assert.AreEqual("MDCCXXV", result);
        }

        [TestMethod]
        public void TestNeg33()
        {
            int x = -33;
            string result = x.ConvertToRomanNumber();

            Assert.AreEqual("", result);
        }


        [TestMethod]
        public void Test3999()
        {
            int x = 3999;
            string result = x.ConvertToRomanNumber();

            Assert.AreEqual("MMMCMXCIX", result);
        }

        [TestMethod]
        public void Test4000()
        {
            int x = 4000;
            string result = x.ConvertToRomanNumber();

            Assert.AreEqual("", result);
        }
    }
}

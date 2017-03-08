using System;
using NUnit.Framework;
using ProblemClassLibrary;

namespace UnitTests
{
    public class UnitTestsGetEthosCoolNumbers
    {

        private getEthosCoolNumbers ethos;

        public UnitTestsGetEthosCoolNumbers()
        {
            ethos = new getEthosCoolNumbers();
            //string answer = ethos.getAllWebRequests();
            //string secondAnswer = ethos.submitAnswer("ilovejavascript");
        }

        [Test]
        [TestCase(23, 13)]
        [TestCase(13, 10)]
        [TestCase(10, 1)]
        [TestCase(532, 38)]
        public void Test_GetSumOfDigitsSquared(int x, int expected)
        {
            Assert.AreEqual(ethos.getSquareOfDigits(x), expected);
        }

        [Test]
        [TestCase(23, true)]
        [TestCase(4, false)]
        [TestCase(16, false)]
        [TestCase(25, false)]
        [TestCase(31, true)]
        [TestCase(100, true)]
        [TestCase(7, true)]
        public void Test_IsCoolNumber(int x, Boolean expected)
        {
            Assert.AreEqual(ethos.isCoolNumber(x), expected);
        }

        [Test]
        [TestCase(1, 10, 18)]
        //[TestCase(1, 1000000, 70601040511)]
        public void Test_CountCoolNumbers(int from, int upto, Int64 expected)
        {
            Assert.AreEqual(ethos.sumOfCoolNumbers(from, upto), expected);
        }
    }
}

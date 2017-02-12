using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using ProblemClassLibrary;

namespace UnitTests
{
    /// <summary>
    /// Tests Euler Problem #6
    /// </summary>
    public class UnitTestsEulerSumSquareDifference
    {
        private eulerSumSquareDifference essd;

        public UnitTestsEulerSumSquareDifference()
        {
            essd = new eulerSumSquareDifference();
        }

        #region Additional test attributes
        private TestContext testContextInstance;
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [Test]
        [TestCase(1, 10, 55)]
        [TestCase(1, 5, 15)]
        public void Test_SumOfRange(int from, int upto, int expected)
        {
            Assert.AreEqual(essd.SumOfRange(from, upto), expected);
        }

        [Test]
        [TestCase(1, 10, 3025)]
        [TestCase(1, 5, 55)]
        public void Test_SumOfSquares(int from, int upto, int expected)
        {
            Assert.AreEqual(essd.SumOfSquares(from, upto), expected);
        }

        [Test]
        [TestCase(1, 10, 2640)]
        [TestCase(1, 100, 0)]
        public void Test_SumSquareDifference(int from, int upto, int expected)
        {
            Assert.AreEqual(essd.SumSquareDifference(from, upto), expected);
        }
    }
}

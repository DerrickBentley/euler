using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using ProblemClassLibrary;

namespace UnitTests
{
    /// <summary>
    /// Test and Answer for Euler problem #8
    /// </summary>
    public class UnitTestsEulerLargestProductInASeries
    {
        private eulerLargestProductInASeries elpias;
        public UnitTestsEulerLargestProductInASeries()
        {
            elpias = new eulerLargestProductInASeries();
        }

        private TestContext testContextInstance;

        #region Additional test attributes
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
        [TestCase(3, 5832)]
        [TestCase(12, 23514624000)]
        public void Test_Largest_Product_Given_Adjacent(int terms, Int64 expected)
        {
            Assert.AreEqual(elpias.largestProduct(terms), expected);
        }
    }
}

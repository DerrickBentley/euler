using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using ProblemsClassLibrary;

namespace UnitTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    public class UnitTestsEuler
    {

        private eulerSmallestMultiple eulerSmallestMultiple;
        public UnitTestsEuler()
        {
            //
            // TODO: Add constructor logic here
            //
            eulerSmallestMultiple = new eulerSmallestMultiple();
        }

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
        [TestCase(1, 10, 2520, true)]
        //[TestCase(1, 20, 232792560, true)]
        public void euler_problem_5_isDivisibleEvenly(int from, int upto, int number, bool expected)
        {
            Assert.AreEqual(eulerSmallestMultiple.isDivisibleEvenly(from, upto, number), expected);
        }

        [Test]
        [TestCase(1, 10,2520)]
        //[TestCase(1, 20, 232792560)]
        public void euler_problem_5_findSmallestMultiple(int from, int upto, int expected)
        {
            Assert.AreEqual(eulerSmallestMultiple.findSmallestMultipleWithRange(from, upto), expected);
        }

    }
}

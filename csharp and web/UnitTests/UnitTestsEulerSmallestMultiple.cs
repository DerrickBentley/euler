﻿using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using ProblemClassLibrary;

namespace UnitTests
{
    /// <summary>
    /// Tests Euler Problem #5
    /// </summary>
    public class UnitTestsEulerSmallestMultiple
    {

        private eulerSmallestMultiple eulerSmallestMultiple;

        public UnitTestsEulerSmallestMultiple()
        {
            eulerSmallestMultiple = new eulerSmallestMultiple();
        }

        #region still need to find what this is
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
        #endregion

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
        public void Test_isDivisibleEvenly(int from, int upto, int number, bool expected)
        {
            Assert.AreEqual(eulerSmallestMultiple.isDivisibleEvenly(from, upto, number), expected);
        }

        [Test]
        [TestCase(1, 10,2520)]
        //[TestCase(1, 20, 232792560)]
        public void Test_findSmallestMultiple(int from, int upto, int expected)
        {
            Assert.AreEqual(eulerSmallestMultiple.findSmallestMultipleWithRange(from, upto), expected);
        }

    }
}

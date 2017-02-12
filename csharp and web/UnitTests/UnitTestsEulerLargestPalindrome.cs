using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using ProblemsClassLibrary;

namespace UnitTests
{
    /// <summary>
    /// Summary description for UnitTestsEulerProblem4
    /// </summary>
    public class UnitTestsEulerLargestPalindrome
    {
        private eulerLargestPalindrome elp;
        public UnitTestsEulerLargestPalindrome()
        {
            elp = new eulerLargestPalindrome();
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
        [TestCase("racecar", "racecar")]
        [TestCase("abcdefg", "gfedcba")]
        [TestCase("", "")]
        [TestCase("a", "a")]
        [TestCase("abcdefggfedcba", "abcdefggfedcba")]
        [TestCase("Derrick", "kcirreD")]
        public void Test_Is_Reverse_Word(String word, String expected)
        {
            Assert.AreEqual(elp.reversedWord(word), expected);
        }

        [Test]
        [TestCase("racecar", true)]
        [TestCase("abcdefg", false)]
        [TestCase("", false)]
        [TestCase("a", true)]
        [TestCase("abcdefggfedcba", true)]
        [TestCase("Derrick", false)]
        public void Test_Is_Valid_Palindrome(String word, bool expected)
        {
            Assert.AreEqual(elp.isPalindrome(word), expected);
        }

        [Test]
        [TestCase(0, 99, 9009)]
        [TestCase(100, 999, 906609)]
        public void Test_Answer_To_Question_4(int from, int upto, int expected)
        {
            Assert.AreEqual(elp.findLargestPalindrome(from, upto), expected);
        }
            
    }
}

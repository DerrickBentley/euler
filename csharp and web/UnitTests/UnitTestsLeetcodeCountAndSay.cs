using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ProblemClassLibrary;
using Assert = NUnit.Framework.Assert;

namespace UnitTests
{
    /// <summary>
    /// Unit tests for UnitTestsLeetcodeCountAndSay
    /// </summary>
    public class UnitTestsLeetcodeCountAndSay
    {
        private leetcodeCountAndSay lcCAS;
        public UnitTestsLeetcodeCountAndSay()
        {
            lcCAS = new leetcodeCountAndSay();
        }


        [Test]
        [TestCase(1, "1")]
        [TestCase(2, "11")]
        [TestCase(3, "21")]
        [TestCase(4, "1211")]
        [TestCase(5, "111221")]
        [TestCase(6, "312211")]
        [TestCase(7, "13112221")]
        public void Test_Count_Say_Term(int term, String expected)
        {
            Assert.AreEqual(lcCAS.CountAndSay(term), expected);
        }

        [Test]
        [TestCase("1", "11")]
        [TestCase("11", "21")]
        [TestCase("21", "1211")]
        [TestCase("1211", "111221")]
        [TestCase("111221", "312211")]
        [TestCase("Derrick", "1D1e2r1i1c1k")]
        [TestCase("Missiippi", "1M1i2s2i2p1i")]
        public void Test_Count_Say(string input, string expected)
        {
            Assert.AreEqual(lcCAS.CountAndSay(input), expected);
        }
        

        [Test]
        [TestCase("Derr", 0, 1)]
        [TestCase("DDerr", 0, 2)]
        [TestCase("D", 0, 1)]
        [TestCase("1111111111", 0, 10)]
        [TestCase("ImInTheMiddle", 9, 2)]
        [TestCase("ImInTheMiddddle", 9, 4)]
        [TestCase("ImInTheMiddddle", 11, 2)]
        [TestCase("ImAtTheEnddd", 11, 1)]
        [TestCase("ImAtTheEnddd", 9, 3)]
        public void Test_Recurring_Prefixes(string input, int index, int expected)
        {
            Assert.AreEqual(lcCAS.countRepeatAtIndex(input, index), expected);
        }
    }
}

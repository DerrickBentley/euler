using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using ProblemClassLibrary;

namespace UnitTests
{
    /// <summary>
    /// Unit Tests for UnitTestLeetcodeLongestCommonPrefix
    /// </summary>
    public class UnitTestsLeetcodeLongestCommonPrefix
    {
        private leetcodeLongestCommonPrefix lcLCP;
        public UnitTestsLeetcodeLongestCommonPrefix()
        {
            lcLCP = new leetcodeLongestCommonPrefix();
        }

        [Test]
        [TestCase("abc", "def", "")]
        [TestCase("DerrickBentley", "DerrickJeter", "Derrick")]
        [TestCase("DoctorSmith", "DocSmith", "Doc")]
        [TestCase("thisIsAnotherTest", "thisIsNotATest", "thisIs")]
        public void Test_MatchingPrefix(String a, String b, String expected)
        {
            Assert.AreEqual(lcLCP.MatchingPrefix(a, b), expected);
        }

        [Test]
        [TestCase(new String[] { "DerrickBentley", "DerrickJeter", "Deryll" }, "Der")]
        [TestCase(new String[] { "Derrick", "Tim", "Deryll" }, "")]
        [TestCase(new String[] { "DoctorSmith", "DoctorBrown", "DoctorPryslek" }, "Doctor")]
        [TestCase(new String[] { "DoctorSmith", "DoctorBrown", "DocPryslek" }, "Doc")]
        [TestCase(new String[] { "DoctorSmith", "DoctorBrown", "" }, "")]
        [TestCase(new String[] { "DerrickBentley", "", "Deryll" }, "")]
        [TestCase(new String[] { "DoctorSmithensin", "DoctorBrown", "DoctOct" }, "Doct")]
        public void Test_LongestPrefix(String[] words, String expected)
        {
            Assert.AreEqual(lcLCP.LargestPrefix(words), expected);
        }
    }
}

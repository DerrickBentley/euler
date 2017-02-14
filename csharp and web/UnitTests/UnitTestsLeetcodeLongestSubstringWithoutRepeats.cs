using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using ProblemClassLibrary;

namespace UnitTests
{
    /// <summary>
    /// Unit Tests for  leetcodeLongestSubstringWithoutRepeats
    /// </summary>
    public class UnitTestsLeetcodeLongestSubstringWithoutRepeats
    {
        private leetcodeLongestSubstringWIthoutRepeats lcLSWR;
        public UnitTestsLeetcodeLongestSubstringWithoutRepeats()
        {
            lcLSWR = new leetcodeLongestSubstringWIthoutRepeats();
        }

        [Test]
        [TestCase("abcabccbb", "abc")]
        [TestCase("bbbbbb", "b")]
        [TestCase("pwwkew", "wke")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz")]
        [TestCase("Test", "Test")]

        public void Test_Leetcode_Longest_SubString_Without_Repeats(String a, String expected)
        {
            Assert.AreEqual(lcLSWR.findSubstring(a), expected);
        }
    }
}

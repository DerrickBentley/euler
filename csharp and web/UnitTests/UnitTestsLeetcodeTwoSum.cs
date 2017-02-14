using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using ProblemClassLibrary;

namespace UnitTests
{
    /// <summary>
    /// unit tests for two sum
    /// </summary>
    public class UnitTestsLeetcodeTwoSum
    {

        private leetcodeTwoSum lcTS;

        public UnitTestsLeetcodeTwoSum()
        {
            lcTS = new leetcodeTwoSum();
        }

        [Test]
        [TestCase(new int[] { 2, 7, 11, 15 },  9, new int[] { 0, 1 })]
        [TestCase(new int[] { 2, 7, 11, 15 }, 13, new int[] { 0, 2 })]
        [TestCase(new int[] { 2, 7, 11, 15 }, 17, new int[] { 0, 3 })]
        [TestCase(new int[] { 2, 7, 11, 15 }, 18, new int[] { 1, 2 })]
        [TestCase(new int[] { 2, 7, 11, 15 }, 22, new int[] { 1, 3 })]
        [TestCase(new int[] { 2, 7, 11, 15 }, 26, new int[] { 2, 3 })]
        [TestCase(new int[] { 2, 7, 11, 15 }, 50, new int[] { 0, 0 })]
        public void Test_Leetcode_TwoSum_Answers(int[] nums, int target, int[] expected)
        {
            Assert.AreEqual(lcTS.TwoSum(nums, target), expected);
        }
    }
}

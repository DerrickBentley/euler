using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ProblemClassLibrary;
using Assert = NUnit.Framework.Assert;

namespace UnitTests
{
    /// <summary>
    /// Test Cases for UnitTestsLeetcodeContainerWithMostWater
    /// </summary>
    public class UnitTestsLeetcodeContainerWithMostWater
    {

        private leetcodeContainerWIthMostWater mostWater;

        public UnitTestsLeetcodeContainerWithMostWater()
        {
            mostWater = new leetcodeContainerWIthMostWater();
        }

        [Test]
        [TestCase(3, 5, 6)]
        [TestCase(1, 10, 9)]
        [TestCase(5, 5, 0)]
        [TestCase(10, 15, 50)]
        public void Test_Finds_Area_Between_Two_Lines(int lineA, int lineB, int expected)
        {
            Assert.AreEqual(mostWater.FindAreaOfContainerForLines(lineA, lineB), expected);
        }

        [Test]
        [TestCase(new int[] {1, 2, 3, 4, 5, 6}, 9)]
        [TestCase(new int[] {5, 6, 7, 8, 9, 10, 11, 12, 13, 14}, 49)]
        [TestCase(new int[] {50, 3, 25}, 625)]
        public void Test_Find_Max_Area(int[] heights, int expected)
        {
            Assert.AreEqual(expected, mostWater.MaxArea(heights));
        }


    }
}

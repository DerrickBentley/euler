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
        [TestCase(1, 5, 2, 4, 4)]
        [TestCase(1, 10, 3, 9, 18)]
        [TestCase(5, 5, 10, 10, 25)]
        [TestCase(0, 10, 5, 25, 50)]
        public void Test_Finds_Area_Between_Two_Lines(int x1, int y1, int x2, int y2, int expected)
        {
            Assert.AreEqual(mostWater.FindAreaOfContainerForLines(x1, y1, x2, y2), expected);
        }

        [Test]
        [TestCase(new int[] {1, 1}, 1)]
        [TestCase(new int[] {1,2,3,4,5}, 6)]
        [TestCase(new int[] {10, 20, 30, 40, 50, 60}, 90)]
        [TestCase(new int[] {1, 2, 3, 5, 8, 13, 21}, 16)]
        [TestCase(new int[] {50, 10, 5, 100}, 150)]
        public void Test_Find_Max_Area(int[] heights, int expected)
        {
            Assert.AreEqual(expected, mostWater.MaxArea(heights));
        }


    }
}

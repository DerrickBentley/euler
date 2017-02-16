using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using ProblemClassLibrary;

namespace UnitTests
{
    /// <summary>
    /// Unit Tests for  LeetcodeValidParentheses
    /// </summary>
    public class UnitTestsLeetcodeValidParentheses
    {
        private leetcodeValidParentheses lcVP;
        public UnitTestsLeetcodeValidParentheses()
        {
            lcVP = new leetcodeValidParentheses();
        }

        [Test]
        [TestCase("[](){}", true)]
        [TestCase("([{}])", true)]
        [TestCase("([{(()[]{})[(){}[]]{{}()[]}}])", true)]
        [TestCase("{]", false)]
        [TestCase("{([]})", false)]
        [TestCase("{{}}[[]](()]", false)]
        public void Test_Is_Valid_Parentheses(String s, Boolean expected)
        {
            Assert.AreEqual(lcVP.isValid(s), expected);
        }
    }
}

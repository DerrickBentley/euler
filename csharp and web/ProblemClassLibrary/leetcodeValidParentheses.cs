using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemClassLibrary
{
    /// <summary>
    /// Given a string containing just the characters '(', ')', '{', '}', '[' and ']',
    /// determine if the input string is valid.
    /// The brackets must close in the correct order, "()" and "()[]{}" are all valid 
    /// but "(]" and "([)]" are not.
    /// </summary>
    public class leetcodeValidParentheses
    {
        private static readonly char[] opens = { '(', '[', '{' };
        private static readonly char[] closes = { ')', ']', '}' };

        public Boolean isValid(String s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (opens.Contains(s[i]))
                {
                    stack.Push(s[i]);
                }
                else
                {
                    int closeType = Array.IndexOf(closes, s[i]);
                    if (closeType < 0)
                        return false;
                    if (stack.Peek() == opens[closeType])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}

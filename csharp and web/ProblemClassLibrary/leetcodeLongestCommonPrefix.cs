using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemClassLibrary
{
    /// <summary>
    /// Write a function to find the longest common prefix string amongst an array of strings.
    /// </summary>
    public class leetcodeLongestCommonPrefix
    {

        /// <summary>
        /// given two strings, find the largest prefix they have in common
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public String MatchingPrefix(String a, String b)
        {
            string result = "";
            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                if (a[i] == b[i])
                {
                    result += a[i];
                }
                else
                {
                    return result;
                }
            }
            return result;
        }

        /// <summary>
        /// given an array of strings, return the largest prefix they have
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public String LargestPrefix(String[] words)
        {
            if (words.Length == 0)
                throw new ArgumentNullException();

            string result = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                result = MatchingPrefix(words[i], result);
            }
            return result;
        }

        /// <summary>
        /// returns the number of letters the largest prefix is within the array of words
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public int LargestPrefixCount(String[] words)
        {
            return LargestPrefix(words).Length;
        }
    }
}

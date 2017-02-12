using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemClassLibrary
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made 
    /// from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public class eulerLargestPalindrome
    {

        public eulerLargestPalindrome()
        {
        }

        /// <summary>
        /// Returns a string in reverse
        /// </summary>
        /// <param name="word">is the string to reverse</param>
        /// <returns></returns>
        public string reversedWord(String word)
        {
            String backwards = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                backwards += word[i];
            }
            return backwards;
        }
        /// <summary>
        /// Tests if a string is a valid palindrome. Palidromes are strings that are the same forwards
        /// and backwards.
        /// </summary>
        /// <example>isPalindrome("racecar") == true</example>
        /// <example>isPalindrome("abcdefg") == false</example>
        /// <param name="word">is the string to check</param>
        /// <returns></returns>
        public bool isPalindrome(String word)
        {
            if (word.Length == 0)
                return false;
            if (word.Length == 1)
                return true;
            return reversedWord(word).Equals(word);
        }

        /// <summary>
        /// given a range of numbers, multiples all combinations to find the
        /// largest palindrome
        /// </summary>
        /// <param name="from"> is the floor of the range</param>
        /// <param name="upto"> is the ceiling of the range</param>
        /// <returns></returns>
       public int findLargestPalindrome(int from, int upto)
        {
            int result = 0;
            for(int i = from; i <= upto; i++)
            {
                for(int j = from; j <= upto; j++)
                {
                    int temp = i * j;
                    if (isPalindrome(Convert.ToString(temp)) && temp > result) {
                        result = temp;
                    }
                }
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ProblemClassLibrary
{
    /// <summary>
    /// The count-and-say sequence is the sequence of integers beginning as follows:
    ///1, 11, 21, 1211, 111221, ...
    ///1 is read off as "one 1" or 11.
    ///11 is read off as "two 1s" or 21.
    ///21 is read off as "one 2, then one 1" or 1211.
    ///Given an integer n, generate the nth sequence.
    /// </summary>
    public class leetcodeCountAndSay
    {

        /// <summary>
        /// produces the nth term of CountAndSay given "1" as the starting point
        /// </summary>
        /// <param name="Term"></param>
        /// <returns></returns>
        public String CountAndSay(int Term)
        {
            String result = "1";
            for (int i = 1; i < Term; i++)
            {
                result = CountAndSay(result);
            }
            return result;
        }
        /// <summary>
        /// for a string, count how many times a character repeats uninterrupted and print that
        /// number next to it.
        /// </summary>
        /// <example>"111" is "31" or "Three Ones"</example>
        /// <param name="x"></param>
        /// <returns></returns>
        public String CountAndSay(String x)
        {
            StringBuilder result = new StringBuilder();
            int i = 0;
            while (i < x.Length)
            {
                int repeats = countRepeatAtIndex(x, i);
                result.Append(repeats.ToString() + x[i].ToString());
                i += repeats;
            }
            return result.ToString();

        }


        /// <summary>
        /// for a given string and an index, return how many times the character repeats uninterrupted
        /// </summary>
        /// <example>countRepeatPrefix("ddderrick", 0) == 3</example>
        /// <param name="x"></param>
        /// <returns>an integer representing how many times the first letter repeats</returns>
        public int countRepeatAtIndex(string x, int index)
        {
            int count = 0;
            char original = x[index];
            for (int i = index; i < x.Length; i++)
            {
                if (x[i] == original)
                {
                    count++;
                }
                else
                {
                    return count;
                }
            }
            return count;
        }
    }
}

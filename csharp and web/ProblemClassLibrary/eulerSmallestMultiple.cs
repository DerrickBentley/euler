using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemClassLibrary
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class eulerSmallestMultiple
    {
        public eulerSmallestMultiple()
        {

        }

        /// <summary>
        /// finds if a number is evenly divisible from a range of numbers. 
        /// </summary>
        /// <param name="from">is the number to begin checking if its a factor</param>
        /// <param name="upto">is the number to end checking if its a factor</param>
        /// <param name="number">is the number we are testing the factors on</param>
        /// <returns></returns>
        public Boolean isDivisibleEvenly(int from, int upto, int number)
        {
            if (from > upto)
            {
                throw new ArgumentOutOfRangeException();
            }
            bool result = true;
            for (int i = from; i <= upto; i++)
            {
                if (number % i != 0)
                {
                    result = false;
                }
            }
            return result;
        }

        /// <summary>
        /// finds the smallest multiple of the number using all numbers from From and up to Upto
        /// </summary>
        /// <param name="from">is the first number we use to factor</param>
        /// <param name="upto">is the last number we use to factor</param>
        /// <example>What number is the smallest that is the multiple of 1 through 5? findSmallestMultipleWithRange(1,5)</example>
        /// <returns></returns>
        public int findSmallestMultipleWithRange(int from, int upto)
        {
            int count = 1;
            while (!isDivisibleEvenly(from, upto, count))
            {
                count++;
            }
            return count;
        }

    }
}

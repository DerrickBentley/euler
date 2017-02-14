using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemClassLibrary
{
    /// <summary>
    /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// </summary>
    public class leetcodeTwoSum
    {

        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] + nums[i] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            return result;
        }
    }
}

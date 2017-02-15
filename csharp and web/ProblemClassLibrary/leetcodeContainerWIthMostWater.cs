using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemClassLibrary
{
    /// <summary>
    /// Given n non-negative integers a1, a2, ..., an, 
    /// where each represents a point at coordinate (i, ai). 
    /// n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). 
    /// Find two lines, which together with x-axis forms a container, 
    /// such that the container contains the most water.
    /// </summary>
    public class leetcodeContainerWIthMostWater
    {

        /// <summary>
        /// for two coordinates that extend down to the x axis, find the area of the container they form
        /// that could hold water.
        /// </summary>
        /// <param name="x1">is the x value in the first coordinate</param>
        /// <param name="y1">is the y value in the first coordinate</param>
        /// <param name="x2">is the x value in the second coordinate</param>
        /// <param name="y2">is the y value in the second coordinate</param>
        /// <example> if coordinate 1 is (5, 5) and coordinate 2 is (3,3) then the rectangle they 
        /// form has a width of 2 (5-3) and a height of 3. resulting in an area of 6
        /// </example>
        /// <returns></returns>
        public int FindAreaOfContainerForLines(int x1, int y1, int x2, int y2)
        {
            int distanceBetween = Math.Abs(x1 - x2);
            int smallestHeight = y1 > y2 ? y2 : y1;
            return distanceBetween * smallestHeight;
        }


        /// <summary>
        /// for an array of ints representing the height of a coordinate, and the index within the array
        /// representing the x value, the line forms a wall that extends from its coordinate down to the
        /// x axis. finds the combination within the array that contains the most water
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public int MaxArea(int[] heights)
        {
            //a container must have atleast two sides.
            if (heights.Length < 2)
            {
                throw new ArgumentException();
            }
            int maxArea = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                for (int j = i; j < heights.Length; j++)
                {
                    int currentArea = FindAreaOfContainerForLines(i, heights[i], j, heights[j]);
                    if (currentArea > maxArea)
                    {
                        maxArea = currentArea;
                    }
                }
            }
            return maxArea;
        }
    }
}

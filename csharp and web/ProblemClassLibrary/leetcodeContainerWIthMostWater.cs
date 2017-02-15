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
        /// given two sides of a rectangle, return the area
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        private int AreaOfRect(int width, int height)
        {
            return width * height;
        }

        /// <summary>
        /// For two lines, the highest height that can retain water is going to be the smallest one
        /// the width of the container is the absolute value between the two points
        /// </summary>
        /// <param name="lineA">is the number representing the point (i, ai)</param>
        /// <param name="lineB"></param>
        /// <example> if line A is 5, then its bottom is at (5, 0) and its top is at (5,5).
        /// if line B is 3, then its bottom is at (3, 0), and its top is at (3,3).
        /// the distance between these two points (width) is |3-5| = 2, and the height
        /// for containing water is the minimal height between them. in this case 3.
        /// a height of 3 and the width of 2 will return an area of 6.
        /// </example>
        /// <returns></returns>
        public int FindAreaOfContainerForLines(int lineA, int lineB)
        {
            int distanceBetween = Math.Abs(lineA - lineB);
            int smallestHeight = lineA > lineB ? lineB : lineA;
            return AreaOfRect(distanceBetween, smallestHeight);
        }


        /// <summary>
        /// for an array of ints representing a point (a,a) that descends down to the x axis,
        /// find the combination that produces the container that holds the most water.
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
                    int currentArea = FindAreaOfContainerForLines(heights[i], heights[j]);
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

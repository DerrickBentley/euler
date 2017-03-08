using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemClassLibrary
{
    /// <summary>
    /// You are given an n x n 2D matrix representing an image.
    /// Rotate the image by 90 degrees(clockwise).
    /// </summary>
    public class leetcodeRotateImage
    {


        public void Rotate(int[,] matrix)
        {
            int[,] temp = matrix;
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; i < matrix.Length; ++j)
                {
                    matrix[i,j] = temp[matrix.Length - j - 1, i];
                }
            }
        }
    }
}

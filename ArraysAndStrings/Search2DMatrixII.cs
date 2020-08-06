using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    //Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:
    //Integers in each row are sorted in ascending from left to right.
    //Integers in each column are sorted in ascending from top to bottom.
    //Time complexity : O(n+m) The key to the time complexity analysis is noticing that, on every iteration(during which we do not return true) either row or col is is decremented/incremented exactly once.
    //Because row can only be decremented mm times and col can only be incremented nn times before causing the while loop to terminate, the loop cannot run for more than n+mn+m iterations.
    //Because all other work is constant, the overall time complexity is linear in the sum of the dimensions of the matrix.
    //Space complexity : O(1) Because this approach only manipulates a few pointers, its memory footprint is constant.
    public class Search2DMatrixII
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int row = matrix.GetLength(0) - 1;
            int col = 0;
            while(row >= 0 && col < matrix.GetLength(1))
            {
                if (matrix[row, col] > target)
                    row--;
                else if (matrix[row, col] < target)
                    col++;
                else
                    return true;
            }
            return false;
        }
    }
}

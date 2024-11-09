using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _74
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int rows = matrix.Count();
            int top = 0;
            int bottom = rows - 1;

            while (top <= bottom)
            {
                int midRow = (top + bottom) / 2;
                if (matrix[midRow][0] <= target && target <= matrix[midRow][matrix[midRow].Count() - 1])
                {
                    int left = 0;
                    int right = matrix[midRow].Count() - 1;

                    while (left <= right)
                    {
                        int midCol = (left + right) / 2;
                        int value = matrix[midRow][midCol];
                        if (value == target) return true;
                        else if (value < target) left = midCol + 1;
                        else right = midCol - 1;
                    }
                    return false;

                }
                else if (matrix[midRow][0] < target) top = midRow + 1;
                else if (matrix[midRow][0] > target) bottom = midRow - 1;
            }

            return false;
        }
    }
}

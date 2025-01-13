using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _240
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            //int r1 = 0, r2 = matrix.Count();
            int c = matrix.Length;
            HashSet<int> idxr = new ();

            int m = matrix.GetLength(0);

            for (int i = 0; i < c; i++)
            {
                if (matrix[i][0] <= target && target <= matrix[i][c - 1]) idxr.Add(i);
            }


            foreach (int i in idxr)
            {
                int l = 0, r = c - 1;

                while(l < r)
                {
                    int mid =  l + ((r - l) / 2);

                    if (matrix[i][mid] == target) return true;
                    else if (matrix[i][mid] > target) r = mid - 1;
                    else l= mid + 1;
                }

                if (matrix[i][l] == target || matrix[i][r] == target) return true;
            }

            return false;
            
        }
    }
}

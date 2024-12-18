using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _48
    {
        public void Rotate(int[][] matrix)
        {
            HashSet<(int, int)> done = new HashSet<(int, int)>();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if(!done.Contains((i, j)))
                    {
                        // rotate (swap values)
                        var temp_ij = matrix[i][j];

                        matrix[i][j] = matrix[j][i];

                        matrix[j][i] = temp_ij;

                        // add i,j and j,i to done
                        done.Add((i, j));
                        done.Add((j, i));
                    }
                }
            }

            foreach(var row in matrix)
            {
                Array.Reverse(row);
            }

        }
    }
}

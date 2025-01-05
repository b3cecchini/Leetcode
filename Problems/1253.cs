using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _1253
    {
        public int OddCells(int m, int n, int[][] indices)
        {
            // init matrix
            int[][] matrix = new int[m][];
            for (int i = 0; i < m; i++) 
            {
                int[] temp = new int[n];
                for(int j = 0; j < n; j++)
                {
                    temp[j] = 0;
                }
                matrix[i] = temp;
            }

            //
            foreach (var idx in indices) 
            {
                //Console.WriteLine($"indicies value: {idx[0]}, {idx[1]}");
                // loop through the row idx[0]
                //Console.WriteLine("targeting row: " +  idx[0].ToString());
                for (int i = 0; i < matrix[0].Length; i++)
                {
                    //Console.WriteLine($"incrementing element: [ {idx[0]},{i} ]");
                    matrix[idx[0]][i]++;
                }
                //Console.WriteLine();

                //Console.WriteLine("targeting col: " + idx[1].ToString());
                for (int i = 0; i < matrix.Length; i++)
                {
                    //Console.WriteLine($"incrementing element: [ {i},{idx[1]} ]");
                    matrix[i][idx[1]]++;
                }

                //Console.WriteLine();
                //Console.WriteLine("********************************");
                //Console.WriteLine();
            }

            int retval = 0;

            for (int r = 0; r < matrix.Length; r++)
            {
                for (int c = 0; c < matrix[r].Length; c++)
                {
                    retval += matrix[r][c] % 2 == 1 ? 1 : 0;
                }
            }


            return retval;
        }
    }
}

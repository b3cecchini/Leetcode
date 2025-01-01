using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _498
    {


        // [2,5],[8,4],[0,-1]
        public int[] FindDiagonalOrder(int[][] mat)
        {
            List<int> retval = new List<int>();
            bool done = false;
            bool goingUp = true;
            int num_rows = mat.Length;
            int num_cols = mat[0].Length; 
            int row = 0, col = 0;
            while(!done)
            {
                // Add current 
                retval.Add(mat[row][col]);

                // bottom reached, we're done
                if (row == num_rows - 1 && col == num_cols - 1) { done = true; continue; }
                
                // Traversing up and to the right
                if(goingUp)
                {
                    // if corner, go down row and kkep colum the same 
                    if(row == 0 && col == num_cols - 1)
                    {
                        row++;
                        goingUp = false;
                        continue;
                    }
                    // if top row but not corner, go to next col value and change direction
                    if(row == 0)
                    {
                        col++;
                        goingUp=false;
                        continue;
                    }
                    if(col == num_cols - 1)
                    {
                        row++;
                        goingUp = false;
                        continue;
                    }

                    row--;
                    col++;
                }
                else // goingDown 
                {
                    // if corner, go next col and keep row the same
                    if (col == 0 && row == num_rows - 1)
                    {
                        col++;
                        goingUp = true;
                        continue;
                    }
                    // if left col, go to next row value and change direction
                    if (col == 0)
                    {
                        row++;
                        goingUp = true;
                        continue;
                    }
                    if (row == num_rows - 1)
                    {
                        col++;
                        goingUp = true;
                        continue;
                    }

                    row++;
                    col--;
                }

                
            }

            return retval.ToArray();
        }
    }
}

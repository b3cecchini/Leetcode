using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _1380
    {
        /*
            0,0 = 3
            0,1 = 7
            0,2 = 8
            1,0 = 9
            1,1 = 11
            1,2 = 13
            2,0 = 15
            2,1 = 16
            2,2 = 17
    
      `0 | 3   7   8  
      `1 | 9   11  13 
      `2 | 15  16  17
         ------------
          `0  `1  `2


            1  10  4  2
            9  3   8  7
            15 16  17 12
        */
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            int colNum = matrix[0].Length;
            int rowNum = matrix.Length;
            //Console.WriteLine($"maxtrix has {rowNum} rows & {colNum} cols");
            List<int> ans = new List<int>();
            for(int i = 0; i < rowNum; i++)
            {
                //Console.WriteLine($"******** New i is {i}**********");
                var min = matrix[i].Min();
                var minIndex = Array.IndexOf(matrix[i], min); 
                //Console.WriteLine($"min value for row {i} is: {min}");
                bool isMax = true;
                //Console.WriteLine($"minIndex is {minIndex}");
                for(int j = 0;j < rowNum; j++)
                {
                    //Console.WriteLine($"j is {j}");
                    //Console.WriteLine($"comparing {matrix[j][minIndex]} to {min}: {matrix[j][minIndex] > min}");
                    if (matrix[j][minIndex] > min)
                    {
                        isMax = false;
                        break;
                    }
                }
                if (isMax) { ans.Add(min); }
                
            }
            return ans;
        }
    }
}

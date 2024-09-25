using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _283
    {
        public void MoveZeroes_ReverseOrder(int[] nums)
        {
            // this was my first implementation and starts the second pointer search from the back of the array
            // which results in the reverse relative order of non zero values
            int i = 0; int j = nums.Length - 1;

            bool foundLeft = false, foundRight = false;
            while(i < j)
            {
                if (nums[i] == 0) foundLeft = true;
                else i++;
                if (nums[j] != 0) foundRight = true;
                else j--;
                if (foundLeft && foundRight)
                {
                    nums[i] = nums[j];
                    nums[j] = 0;
                    foundLeft = false;
                    foundRight = false;
                    i++;
                    j--;
                }     
            }
        }


        public void MoveZeroes(int[] nums)
        {
            for(int i= 0; i < nums.Length; i++)
            {
                // if find a zero, search to the right until you find a non-zero and then swap
                if (nums[i] == 0)
                {
                    for (int j = i + 1;  j < nums.Length; j++)
                    {
                        if (nums[j] != 0) 
                        {
                            nums[i] = nums[j];
                            nums[j] = 0;
                            break;
                        }
                    }
                }
            }
        }
    }
}

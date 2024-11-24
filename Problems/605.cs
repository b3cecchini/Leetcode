using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _605
    {
        // problem 605
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {

            for (int i = 0; i < flowerbed.Length; i++)
            {
                bool placeLeft = i == 0 || flowerbed[i - 1] == 0;
                bool placeRight = i == flowerbed.Length - 1 || flowerbed[i + 1] == 0;

                if (flowerbed[i] == 0 && placeLeft && placeRight)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }

            return n <= 0;
        }
    }
}

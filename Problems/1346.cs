using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _1346
    {
        public bool CheckIfExist(int[] arr)
        {
            HashSet<int> h = new HashSet<int>();

            foreach (int i in arr)
            {
                if (h.Contains(i * 2) || (h.Contains(i / 2) && (i%2 == 0))) return true; 
                h.Add(i);
            }

            return false;
        }
    }
}

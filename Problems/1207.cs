using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _1207
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dict = new();

            foreach (var item in arr)
            {
                if(dict.ContainsKey(item))
                {
                    dict[item] += 1;
                }
                else 
                {
                    dict.Add(item, 1);
                }
            }

            HashSet<int> list = new HashSet<int>();
            foreach (var item in dict.Values) 
            {
                if (!list.Add(item)) return false;
            
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _2418
    {
        public string[] SortPeople(string[] names, int[] heights)
        {
            List<string> list = new List<string>();
            SortedDictionary<int, string> dict = new();

            for(int i = 0; i < names.Length; i++)
            {
                dict.Add(heights[i], names[i]);
            }

            foreach (KeyValuePair<int, string> val in dict.OrderByDescending(i => i.Key))
            {
                list.Add(val.Value);
            }

            return list.ToArray();
        }
    }
}

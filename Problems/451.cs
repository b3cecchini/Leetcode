using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _451
    {
        public string FrequencySort(string s)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            
            foreach (char c in s)
            {
                if(counts.ContainsKey(c)) counts[c]++;
                else counts[c] = 1;
            }

            StringBuilder sb = new StringBuilder();

            foreach (var k in counts.OrderByDescending(pair => pair.Value).Select(pair => pair.Key))
            {
                for (int i = 0; i < counts[k]; i++) sb.Append(k, 2);
            }

            return sb.ToString();
        }
    }
}

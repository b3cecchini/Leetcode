using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _49
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();

            foreach(var word in strs)
            {
                var arr = word.ToCharArray();
                Array.Sort(arr);
                var s = new string(arr);

                if (dict.ContainsKey(s)) dict[s].Add(word);
                
                else dict.Add(s, new List<string>() { word });
            }

            return dict.Values.ToList();

        }
    }
}

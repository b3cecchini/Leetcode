using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _811
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<string> retval = new();

            foreach (string value in cpdomains)
            {
                var divided = value.Split(" ");
                var visits = Int32.Parse(divided[0]);
                var domain = divided[1];
                while(domain.Contains(".")) 
                {
                    if (dict.ContainsKey(domain)) dict[domain] += visits;
                    else dict[domain] = visits;
                    int i = 0;
                    while (domain[i] != '.') i++;
                    domain = domain.Substring(i + 1);
                }

                if (dict.ContainsKey(domain)) dict[domain] += visits;
                else dict[domain] = visits;
            }

            foreach (var kv in dict) retval.Add($"{kv.Value} {kv.Key}");

            return retval;

        }
    }
}

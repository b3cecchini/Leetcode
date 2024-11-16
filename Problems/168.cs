using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _168
    {
       /* Dictionary<int, char> dict = Enumerable.Range(1, 26)
            .ToDictionary(
                key => key,
                value => (char)('A' + value - 1)
            );*/


        public string ConvertToTitle(int columnNumber)
        {

            StringBuilder title = new();
            while (columnNumber > 0)
            {
                title.Insert(0, (char)(((columnNumber - 1) % 26) + 'A'));
                columnNumber = (columnNumber - 1) / 26;
            }

            return title.ToString();
        }
    }
}

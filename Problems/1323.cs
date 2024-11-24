using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _1323
    {
        public int Maximum69Number(int num)
        {
            var str_num = num.ToString().ToCharArray();
            var max = num;
            for (int i =0;  i < str_num.Length; i++)
            {
                if (str_num[i] != '9')
                {
                    str_num[i] = '9';
                    max = Math.Max(max, Int32.Parse(str_num));
                    str_num[i] = '6';
                }
            }
            return max;
        }


    }
}

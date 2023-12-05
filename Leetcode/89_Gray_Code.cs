using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _89_Gray_Code
    {
        public IList<int> GrayCode(int n)
        {
            var length = Math.Pow(2, n);
            var list = new List<int>();

            for (var index = 0; index < length; index++)
            {
                list.Add(GetGrayCode(index));
            }

            return list;
        }

        public int GetGrayCode(int n)
        {

            return n ^ (n >> 1);
        }
    }
}

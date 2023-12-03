using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _1071_Greatest_Common_Divisor_of_Strings
    {
        // Euclidean Algorithm
        public string GcdOfStrings(string str1, string str2)
        {
            if (!string.Equals(str1 + str2, str2 + str1))
            {
                return "";
            }

            int len1 = str1.Length;
            int len2 = str2.Length;

            while (len2 != 0)
            {
                int temp = len2;
                len2 = len1 % len2;
                len1 = temp;
            }

            return str1.Substring(0, len1);
        }
    }
}

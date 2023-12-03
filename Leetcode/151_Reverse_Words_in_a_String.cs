using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _151_Reverse_Words_in_a_String
    {
        public string ReverseWords(string s)
        {
            return string.Join(" ", s.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse()).Trim();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _392_Is_Subsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            var sPointer = 0;
            var tPointer = 0;

            while (sPointer < s.Length && tPointer < t.Length)
            {
                if (s[sPointer] == t[tPointer])
                {
                    sPointer++;
                    tPointer++;
                }
                else
                {
                    tPointer++;
                }
            }

            return sPointer == s.Length;
        }
    }
}

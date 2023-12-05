using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _14_Longest_Common_Prefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var minLength = strs.Min(x => x.Length);
            var longestPrefix = string.Empty;
            var shortest = strs.FirstOrDefault(x => x.Length == minLength);

            for (var index = 0; index < shortest.Length; index++)
            {
                var substring = shortest.Substring(0, index + 1);

                if (strs.All(x => x.StartsWith(substring)))
                {
                    longestPrefix = substring;
                }
            }

            return longestPrefix;
        }
    }
}

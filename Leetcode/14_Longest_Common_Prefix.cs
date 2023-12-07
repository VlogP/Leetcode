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
            if (strs.Count() == 1) return strs[0];
            if (strs.Count() == 0) return "";

            var minLength = strs.Min(x => x.Length);
            var count = strs.Count();
            var longestPrefix = string.Empty;

            Array.Sort(strs);

            for (var index = 0; index < strs[0].Length; index++)
            {
                if (strs[0][index] != strs[strs.Length - 1][index])
                {
                    break;
                }
                else
                {
                    longestPrefix += strs[0][index];
                }
            }

            return longestPrefix;
        }

        /*
                         public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Count() == 1) return strs[0];
            if (strs.Count() == 0) return "";

            var minLength = strs.Min(x => x.Length);
            var count = strs.Count();
            var longestPrefix = string.Empty;
            var shortestIndex = Array.FindIndex(strs, x => x.Length == minLength);

            for (var index = 0; index < strs[shortestIndex].Length; index++)
            {
                var substring = strs[shortestIndex].Substring(0, index + 1);

                for (var index2 = 0; index2 < count; index2++)
                {
                    if (index2 != shortestIndex)
                    {
                        if (IsPrefix(strs[index2], substring))
                        {
                            if (index2 == count - 1)
                            {
                                longestPrefix = substring;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {

                        if (shortestIndex == count - 1)
                        {
                            if (IsPrefix(strs[index2], substring))
                                longestPrefix = substring;
                        }
                    }
                }
            }

            return longestPrefix;
        }

        public bool IsPrefix(string str, string prefix)
        {
            for (var index3 = 0; index3 < prefix.Length; index3++)
            {
                if (str[index3] != prefix[index3])
                {
                    return false;
                }
            }

            return true;
        }
         */






        /*
        public string LongestCommonPrefix(string[] strs) 
    {
        var minLength = strs.Min(x => x.Length);
        var longestPrefix = string.Empty;
        var shortest = strs.FirstOrDefault(x => x.Length == minLength);

        for(var index = 0; index < shortest.Length; index++)
        {
            var substring = shortest.Substring(0, index + 1);

            if (strs.All(x => x.StartsWith(substring)))
            {
                longestPrefix = substring;
            }
        }

        return longestPrefix;
    }
         */
    }
}

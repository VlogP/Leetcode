using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _49_Group_Anagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var result = new Dictionary<string, IList<string>>();

            foreach (var str in strs)
            {
                char[] strChar = str.ToCharArray();
                Array.Sort(strChar);
                var sortedStr = new string(strChar);

                if (result.ContainsKey(sortedStr))
                {
                    result[sortedStr].Add(str);
                }
                else
                {
                    result.Add(sortedStr, new List<string>() { str });
                }
            }

            return result.Values.ToList();
        }
    }
}

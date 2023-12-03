using System.Text;

namespace Leetcode
{
    internal class _1768_Merge_Strings_Alternately
    {
        public string MergeAlternately(string word1, string word2)
        {
            var length = Math.Max(word1.Length, word2.Length);
            StringBuilder mergeString = new();

            for (var i = 0; i < length; i++)
            {
                if (word1.Length - 1 >= i)
                {
                    mergeString.Append(word1[i]);
                }
                if (word2.Length - 1 >= i)
                {
                    mergeString.Append(word2[i]);
                }
            }

            return mergeString.ToString();
        }
    }
}

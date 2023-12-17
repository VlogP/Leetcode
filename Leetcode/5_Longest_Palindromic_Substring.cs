using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _5_Longest_Palindromic_Substring
    {
        public string LongestPalindrome(string s)
        {
            var length = s.Length;
            var result = string.Empty;

            for (var index = 0; index < length; index++)
            {
                var leftPointer = index;
                var rightPointer = index;
                var palindrom = GetPalindrom(s, leftPointer, rightPointer, length);
                var palindrom2 = GetPalindrom(s, leftPointer, rightPointer + 1, length);

                result = palindrom.Length >= result.Length
                    ? palindrom
                    : result;

                result = palindrom2.Length >= result.Length
                    ? palindrom2
                    : result;
            }

            return result;
        }

        private string GetPalindrom(string s, int leftIndex, int rightIndex, int length)
        {
            while (leftIndex >= 0 && rightIndex < length && s[leftIndex] == s[rightIndex])
            {
                leftIndex--;
                rightIndex++;
            }

            return s.Substring(leftIndex + 1, rightIndex - (leftIndex + 1));
        }

        /*Not Effective O(n^3)
        public string LongestPalindrome(string s) {
            var length = s.Length;
            var result = s;     
            var maxLength = 0;

            if(length != 1){
            for (var index = 1; index <= length; index++)
            {
                for (var index2 = 0; index2 <= length - index; index2++)
                {         
                    var substring = s.Substring(index2, index);
                    var isPalindromic = true;

                    if (substring.Length > 1)
                    {                             
                        for (var index3 = 0; index3 < substring.Length; index3++)
                        {
                            if(substring[substring.Length - index3 - 1] != substring[index3])
                            {
                                isPalindromic = false;
                            }
                        }
                    }

                    if (isPalindromic && maxLength <= substring.Length)
                    {
                        result = substring;
                        maxLength = substring.Length;
                    }
                }
            }                   
            }

            return result;
        }*/
    }
}

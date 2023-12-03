using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _345_Reverse_Vowels_of_a_String
    {
        public string ReverseVowels(string s)
        {
            var stack = new Stack<char>();
            var reversedString = new StringBuilder();
            var vowels = "aeiouAEIOU";

            for (var index = 0; index < s.Length; index++)
            {
                if (vowels.Contains(s[index]))
                {
                    stack.Push(s[index]);
                }
            }

            for (var index = 0; index < s.Length; index++)
            {
                if (vowels.Contains(s[index]))
                {
                    reversedString.Append(stack.Pop());
                }
                else
                {
                    reversedString.Append(s[index]);
                }
            }

            return reversedString.ToString();
        }

        /*
        public string ReverseVowels(string s)
        {
            var reversedSequence = new char[s.Length];
            var reversedString = string.Empty;
            var vowels = "aeiou";
            var counter = 0;

            for (var index = s.Length - 1; index >= 0; index--)
            {
                if (vowels.Contains(char.ToLower(s[index])))
                {
                    reversedSequence[counter] = s[index];
                    counter++;
                }
            }

            counter = 0;

            for (var index = 0; index < s.Length; index++)
            {
                if (vowels.Contains(char.ToLower(s[index])))
                {
                    reversedString += reversedSequence[counter];
                    counter++;
                }
                else
                {
                    reversedString += s[index];
                }
            }

            return reversedString;
        }
        */
    }
}

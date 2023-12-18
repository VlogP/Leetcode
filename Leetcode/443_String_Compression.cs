using System.Text;

namespace Leetcode
{
    internal class _443_String_Compression
    {
        public int Compress(char[] chars)
        {
            var str = new StringBuilder(chars.Length);
            char lastSymbol = chars[0];
            var counter = 0;

            for (var index = 0; index < chars.Length; index++)
            {
                var symbol = chars[index];

                if (lastSymbol != symbol)
                {
                    if (counter == 1)
                    {
                        str.Append(lastSymbol);
                    }
                    else
                    {
                        str.Append(lastSymbol + counter.ToString());
                    }

                    counter = 1;
                }
                else
                {
                    counter++;
                }

                if (index == chars.Length - 1)
                {
                    if (lastSymbol != symbol)
                    {
                        str.Append(symbol);

                        counter = 1;
                    }
                    else
                    {
                        if (counter == 1)
                        {
                            str.Append(lastSymbol);
                        }
                        else
                        {
                            str.Append(lastSymbol + counter.ToString());
                        }
                    }
                }

                lastSymbol = symbol;
            }

            for (var index = 0; index < str.Length; index++)
            {
                chars[index] = str[index];
            }

            return str.Length;
        }
    }
}

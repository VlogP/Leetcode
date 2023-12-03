using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _605_Can_Place_Flowers
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            var length = flowerbed.Length;
            var counter = 0;
            var flowerbed2 = (int[])flowerbed.Clone();

            if (length > 1)
            {
                for (var index = 0; index < length; index++)
                {
                    if (index == 0)
                    {
                        if (flowerbed2[index + 1] != 1 && flowerbed2[index] != 1)
                        {
                            flowerbed2[index] = 1;
                            counter++;
                        }
                    }
                    else if (index == length - 1)
                    {
                        if (flowerbed2[index] != 1 && flowerbed2[index - 1] != 1)
                        {
                            flowerbed2[index] = 1;
                            counter++;
                        }
                    }
                    else
                    {
                        if (flowerbed2[index] != 1 && flowerbed2[index - 1] != 1 && flowerbed2[index + 1] != 1)
                        {
                            flowerbed2[index] = 1;
                            counter++;
                        }
                    }
                }
            }
            else
            {
                return n == 0 || flowerbed2[0] == 0;
            }

            return counter >= n;
        }
    }
}

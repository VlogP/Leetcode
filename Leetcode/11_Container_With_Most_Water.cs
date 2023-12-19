using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _11_Container_With_Most_Water
    {
        public int MaxArea(int[] height)
        {
            var leftPointer = 0;
            var rightPointer = height.Length - 1;
            var maxSize = 0;

            while (leftPointer < rightPointer)
            {
                var square = Math.Min(height[leftPointer], height[rightPointer]) * (rightPointer - leftPointer);
                maxSize = maxSize > square
                    ? maxSize
                    : square;

                if (height[leftPointer] < height[rightPointer])
                {
                    leftPointer++;
                }
                else
                {
                    rightPointer--;
                }
            }

            return maxSize;
        }
    }
}

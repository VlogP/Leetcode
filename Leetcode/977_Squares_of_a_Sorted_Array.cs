using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _977_Squares_of_a_Sorted_Array
    {
        public int[] SortedSquares(int[] nums)
        {
            var result = new int[nums.Length];
            var leftIndex = 0;
            var rightIndex = nums.Length - 1;
            var index = nums.Length - 1;

            while (leftIndex <= rightIndex)
            {
                var leftValue = nums[leftIndex];
                var rightValue = nums[rightIndex];

                if (Math.Abs(leftValue) >= Math.Abs(rightValue))
                {
                    result[index] = (int)Math.Pow(leftValue, 2);
                    leftIndex++;
                    index--;
                }
                else
                {
                    result[index] = (int)Math.Pow(rightValue, 2);
                    rightIndex--;
                    index--;
                }
            }

            return result;
        }
    }
}

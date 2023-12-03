using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _238_Product_of_Array_Except_Self
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var length = nums.Length;
            var output = new int[length];
            var multiplier = 1;
            var index = 0;

            while (index < length)
            {
                output[index] = multiplier;
                multiplier *= nums[index];
                index++;
            }

            index = length - 1;
            multiplier = 1;

            while (index >= 0)
            {
                output[index] *= multiplier;
                multiplier *= nums[index];
                index--;
            }

            return output;
        }
    }
}

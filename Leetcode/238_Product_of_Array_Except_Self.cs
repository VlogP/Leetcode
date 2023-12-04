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

        /*
         public int[] ProductExceptSelf(int[] nums) {
        var length = nums.Length;
        var output = new int[length];
        var index = 0;
        var left = 1;
        var right = 1;

        for(var i = 0; i < length; i++)
            output[i] = 1;

        while (index < length) 
        {  
                    
            output[index] *= left;
            left *= nums[index];

            output[length - index - 1] *= right;
            right *= nums[length - index - 1];

            index++;            
        }

        return output;
    }
         */
    }
}

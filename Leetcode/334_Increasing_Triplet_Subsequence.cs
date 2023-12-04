using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _334_Increasing_Triplet_Subsequence
    {
        public bool IncreasingTriplet(int[] nums)
        {
            var length = nums.Length;
            var result = false;
            var value = int.MaxValue;
            var secondValue = int.MaxValue;

            if (length > 2)
            {
                for (var index = 0; index < length; index++)
                {
                    if (nums[index] <= value)
                    {
                        value = nums[index];
                    }
                    else if (nums[index] <= secondValue)
                    {
                        secondValue = nums[index];
                    }
                    else
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }
    }
}

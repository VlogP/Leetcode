using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _1_Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var hash = new Dictionary<int, int>();

            for (var index = 0; index < nums.Length; index++)
            {
                var value = target - nums[index];

                if (hash.ContainsKey(value))
                    return new int[] { index, hash[value] };

                hash[nums[index]] = index;
            }

            return null;
        }

        /*
        public int[] TwoSum(int[] nums, int target) {
            for (var index = 0; index < nums.Length; index++)
            {
                for (var index2 = 0; index2 < nums.Length; index2++)
                {
                    if (nums[index] + nums[index2] == target && index2 != index)
                    {
                        return new int[]{index, index2};
                    }
                }
            }

            return null;
        }
        */
    }
}

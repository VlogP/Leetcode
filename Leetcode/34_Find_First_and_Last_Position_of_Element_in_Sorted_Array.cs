using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _34_Find_First_and_Last_Position_of_Element_in_Sorted_Array
    {
        public int[] SearchRange(int[] nums, int target)
        {
            return new int[] { FirstPosition(nums, target), LastPosition(nums, target) };
        }

        public int FirstPosition(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            var result = -1;

            while (left <= right)
            {
                var mid = (left + right) / 2;

                if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                    result = mid;
                }
            }

            return result;
        }

        public int LastPosition(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            var result = -1;

            while (left <= right)
            {
                var mid = (left + right) / 2;

                if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    left = mid + 1;
                    result = mid;
                }
            }

            return result;
        }
    }
}

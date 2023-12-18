using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _283_Move_Zeroes
    {
        public void MoveZeroes(int[] nums)
        {
            var zeroPointer = 0;
            var numPointer = 0;

            while (numPointer < nums.Length)
            {
                if (nums[numPointer] == 0)
                {
                    numPointer++;
                }
                else
                {
                    var temp = nums[numPointer];
                    nums[numPointer] = nums[zeroPointer];
                    nums[zeroPointer] = temp;

                    zeroPointer++;
                    numPointer++;
                }
            }
        }
    }
}

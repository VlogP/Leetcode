using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class _1431_Kids_With_the_Greatest_Number_of_Candies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var maxCandies = candies.Max(x => x);

            return candies.Select(x => x + extraCandies >= maxCandies).ToList();
        }
    }
}

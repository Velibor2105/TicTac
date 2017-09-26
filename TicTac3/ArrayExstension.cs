using System.Collections.Generic;
using System.Linq;

namespace TicTac3
{
    public static class ArrayExstension
    {
        public static bool IsSubset(this int[] subSet, IEnumerable<int> superSet)
        {
            return  !subSet.Except(superSet).Any();
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class ContainsDuplicateII
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var indexLookUp = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                indexLookUp.Add(i, nums[i]);
            }

            var duplicateNums = nums.GroupBy(x => x).Where(y => y.Count() >= 2).Select(x => x.Key).ToArray();
            foreach (var num in duplicateNums)
            {
                var keys = indexLookUp.Where(x => x.Value.Equals(num)).Select(x => x.Key).ToArray();
                for (int i = 0; i < keys.Length - 1; i++)
                {
                    if (keys[i + 1] - keys[i] <= k)
                        return true;
                }
            }

            return false;
        }
    }
}
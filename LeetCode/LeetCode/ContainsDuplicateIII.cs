using System;

namespace LeetCode
{
    public class ContainsDuplicateIII
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            if (nums.Length == 0)
                return false;

            for (int i = 0; i < nums.Length; i += (k + 1))
            {
                for (int j = i+1; j < nums.Length && j - i <= k; j++)
                {
                    if (Math.Abs((decimal)nums[i] - nums[j]) <= t)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
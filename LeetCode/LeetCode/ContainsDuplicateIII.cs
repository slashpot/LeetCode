using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class ContainsDuplicateIII
    {
        private int[] _nums;
        private int _maxAbsOfIndex;
        private int _maxAbsOfValue;
        private HashSet<int> _searchedLookUp;

        public bool ContainsNearbyAlmostDuplicate(int[] nums, int maxAbsOfIndex, int maxAbsOfValue)
        {
            GetValuesForFields(nums, maxAbsOfIndex, maxAbsOfValue);

            if (HasOneNumOrKEqualsToZero())
            {
                return false;
            }

            return IsCheckEqual() ? HasDuplicates() : HasDuplicatesWithAbs();
        }

        private void GetValuesForFields(int[] nums, int maxAbsDiffOfIndex, int maxAbsDiffOfValue)
        {
            _nums = nums;
            _maxAbsOfValue = maxAbsDiffOfValue;
            _maxAbsOfIndex = maxAbsDiffOfIndex;
            _searchedLookUp = new HashSet<int>();
        }

        private bool HasOneNumOrKEqualsToZero()
        {
            return _nums.Length <= 1 || _maxAbsOfIndex == 0;
        }

        private bool IsCheckEqual()
        {
            return _maxAbsOfValue == 0;
        }

        private bool HasDuplicates()
        {
            for (int i = 0; i < _nums.Length; i++)
            {
                if (FindDuplicateInLookUp(i))
                {
                    return true;
                }

                AddToLookUp(i);
                RemoveOutOfWindowNumFromLookUp(i);
            }
            return false;
        }

        private bool FindDuplicateInLookUp(int i)
        {
            return _searchedLookUp.Contains(_nums[i]);
        }

        private void AddToLookUp(int i)
        {
            _searchedLookUp.Add(_nums[i]);
        }

        private void RemoveOutOfWindowNumFromLookUp(int i)
        {
            if (i >= _maxAbsOfIndex)
            {
                _searchedLookUp.Remove(_nums[i - _maxAbsOfIndex]);
            }
        }

        private bool HasDuplicatesWithAbs()
        {
            for (int i = 0; i < _nums.Length; i++)
            {
                var highest = GetHighest(i);
                var lowest = GetLowest(i);

                var matchNums = GetNumsInRange(highest, lowest);
                if (HasMatch(matchNums))
                {
                    return true;
                }

                AddToLookUp(i);
                RemoveOutOfWindowNumFromLookUp(i);
            }
            return false;
        }

        private decimal GetHighest(int i)
        {
            return (decimal)_nums[i] + _maxAbsOfValue;
        }

        private decimal GetLowest(int i)
        {
            return (decimal)_nums[i] - _maxAbsOfValue;
        }

        private IEnumerable<int> GetNumsInRange(decimal highest, decimal lowest)
        {
            return _searchedLookUp.Where(x => (x <= highest && x >= lowest));
        }

        private static bool HasMatch(IEnumerable<int> matchNums)
        {
            return matchNums.Count() != 0;
        }
    }
}
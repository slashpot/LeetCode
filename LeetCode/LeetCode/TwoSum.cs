using System.Collections.Generic;

namespace LeetCode
{
    public class TwoSum
    {
        private int[] _numsOfTwoSum;
        private int[] _numsOfInput;
        private int _target;
        private int _current;
        private int _candidate;
        private Dictionary<int, int> _recordsOfSearchedNums;

        public int[] GetTwoSum(int[] nums, int target)
        {
            Initialize(nums, target);
            SearchNumsOfTwoSum();
            return _numsOfTwoSum;
        }

        private void Initialize(int[] nums, int target)
        {
            _target = target;
            _numsOfInput = nums;
            _numsOfTwoSum = new int[2];
            _recordsOfSearchedNums = new Dictionary<int, int>();
        }

        private void SearchNumsOfTwoSum()
        {
            for (int i = 0; i < _numsOfInput.Length; i++)
            {
                SetCurrentSearchingNumAndCandidate(i);
                if (ContainsCandidateInRecords())
                {
                    SetNumsOfTwoSum(i);
                    break;
                }
                AddCurrentInRecordsIfNotExists(i);
            }
        }

        private void SetCurrentSearchingNumAndCandidate(int index)
        {
            _current = _numsOfInput[index];
            _candidate = _target - _current;
        }

        private bool ContainsCandidateInRecords()
        {
            return _recordsOfSearchedNums.ContainsKey(_candidate);
        }

        private void SetNumsOfTwoSum(int i)
        {
            _numsOfTwoSum[0] = _recordsOfSearchedNums[_candidate];
            _numsOfTwoSum[1] = i;
        }

        private void AddCurrentInRecordsIfNotExists(int i)
        {
            if (HasNoCurrentInRecords(_current))
                _recordsOfSearchedNums.Add(_current, i);
        }

        private bool HasNoCurrentInRecords(int current)
        {
            return !_recordsOfSearchedNums.ContainsKey(current);
        }
    }
}
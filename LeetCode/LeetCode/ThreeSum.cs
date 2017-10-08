using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class ThreeSum
    {
        private List<IList<int>> _threeSumNums;
        private int _startPos;
        private int[] _inputNums;

        public IList<IList<int>> GetThreeSum(int[] nums)
        {
            Initialize(nums);

            if (IsInputCountSmallerThanThree())
            {
                return _threeSumNums;
            }

            SortInput();
            GetThreeSumNums();
            return _threeSumNums;
        }

        private void Initialize(int[] nums)
        {
            _inputNums = nums;
            _threeSumNums = new List<IList<int>>();
            _startPos = 0;
        }

        private bool IsInputCountSmallerThanThree()
        {
            return _inputNums.Length < 3;
        }

        private void SortInput()
        {
            Array.Sort(_inputNums);
        }

        private void GetThreeSumNums()
        {
            while (HasUncheckedPos())
            {
                FindThreeSumLists();
                _startPos = SkipSameNumsToNext(_startPos);
            }
        }

        private bool HasUncheckedPos()
        {
            return _startPos < _inputNums.Length - 1;
        }

        private void FindThreeSumLists()
        {
            int checkPos = _startPos + 1;

            while (checkPos < _inputNums.Length)
            {
                int firstThreeSumNum = GetFirstThreeSumNum();
                int secondThreeSumNum = GetSecondThreeSumNum(checkPos);
                int complement = GetComplement(firstThreeSumNum, secondThreeSumNum);
                int nextPos = checkPos + 1;
                checkPos = SkipSameNumsToNext(checkPos);

                if (HasNoComplementInRemainNums(nextPos, complement))
                {
                    continue;
                }

                AddThreeSumNums(firstThreeSumNum, secondThreeSumNum, complement);
            }
        }

        private int GetFirstThreeSumNum()
        {
            return _inputNums[_startPos];
        }

        private int GetSecondThreeSumNum(int checkPos)
        {
            return _inputNums[checkPos];
        }

        private static int GetComplement(int firstThreeSumNum, int secondThreeSumNum)
        {
            return (firstThreeSumNum + secondThreeSumNum) * -1;
        }

        private int SkipSameNumsToNext(int checkPos)
        {
            while (checkPos < _inputNums.Length - 1 && _inputNums[checkPos] == _inputNums[checkPos + 1])
                checkPos++;
            return checkPos + 1;
        }

        private bool HasNoComplementInRemainNums(int nextPos, int complement)
        {
            return Array.BinarySearch(_inputNums, nextPos, _inputNums.Length - nextPos, complement) < 0;
        }

        private void AddThreeSumNums(int first, int second, int complement)
        {
            _threeSumNums.Add(new List<int> { first, second, complement });
        }
    }
}
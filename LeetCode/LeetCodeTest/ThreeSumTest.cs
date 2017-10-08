using LeetCode;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeTest
{
    [TestFixture]
    public class ThreeSumTest
    {
        private static void TestThreeSum(int[] nums, IList<IList<int>> expected)
        {
            ThreeSum threeSum = new ThreeSum();
            IList<IList<int>> actual = threeSum.GetThreeSum(nums);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCase1()
        {
            int[] nums = new int[6] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> expected = new List<IList<int>>
            {
                new List<int> {-1, -1, 2 },
                new List<int> {-1, 0, 1 }
            };
            TestThreeSum(nums, expected);
        }

        [Test]
        public void TestCase2()
        {
            int[] nums = new int[2] { 0, 0 };
            IList<IList<int>> expected = new List<IList<int>>();
            TestThreeSum(nums, expected);
        }

        [Test]
        public void TestCase3()
        {
            int[] nums = new int[6] { 3, 0, -2, -1, 1, 2 };
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int> { -2, -1, 3 },
                new List<int> { -2, 0, 2 },
                new List<int> { -1, 0, 1}
            };
            TestThreeSum(nums, expected);
        }

        [Test]
        public void TestCase4()
        {
            int[] nums = new int[3] { 0, 0, 0 };

            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int> { 0, 0, 0 },
            };
            TestThreeSum(nums, expected);
        }

        [Test]
        public void TestCase5()
        {
            int[] nums = new int[3] { 0, 1, 1 };
            IList<IList<int>> expected = new List<IList<int>>();
            TestThreeSum(nums, expected);
        }

        [Test]
        public void TestCase6()
        {
            int[] nums = new int[15] { -4, -2, -2, -2, 0, 1, 2, 2, 2, 3, 3, 4, 4, 6, 6 };
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int> { -4, -2, 6},
                new List<int> { -4, 0, 4},
                new List<int> { -4, 1, 3},
                new List<int> { -4, 2, 2},
                new List<int> { -2, -2, 4},
                new List<int> { -2, 0, 2},
            };
            TestThreeSum(nums, expected);
        }
    }
}
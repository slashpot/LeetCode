using LeetCode;
using NUnit.Framework;

namespace LeetCodeTest
{
    [TestFixture]
    public class UnitTest1
    {
        private static void TestContainsDuplicate(int[] nums, int k, int t, bool expected)
        {
            var containsDuplicate = new ContainsDuplicateIII();
            var actual = containsDuplicate.ContainsNearbyAlmostDuplicate(nums, k, t);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0] , 0, 0, false)]
        public void TestEmptyArray(int[] nums, int k, int t, bool expected)
        {
            TestContainsDuplicate(nums, k, t, expected);
        }

        [TestCase(new[] { 1 }, 1, 1, false)]
        public void TestOneNumCases(int[] nums, int k, int t, bool expected)
        {
            TestContainsDuplicate(nums, k, t, expected);
        }

        [TestCase(new[] { -1, -1 }, 1, 0, true)]
        [TestCase(new[] { 1, 3, 1 }, 2, 1, true)]
        [TestCase(new[] { 1, 3, 1 }, 1, 1, false)]
        [TestCase(new[] { 1, 2 }, 0, 1, false)]
        [TestCase(new[] { 7, 1, 3 }, 2, 3, true)]
        [TestCase(new[] { -3, 3 }, 2, 4, false)]
        public void TestNormalCases(int[] nums, int k, int t, bool expected)
        {
            TestContainsDuplicate(nums, k, t, expected);
        }

        [TestCase(new[] { -1, 2147483647 }, 1, 2147483647, false)]
        [TestCase(new[] { 0, 2147483647 }, 1, 2147483647, true)]
        public void TestIntMaxValueCases(int[] nums, int k, int t, bool expected)
        {
            TestContainsDuplicate(nums, k, t, expected);
        }
    }
}
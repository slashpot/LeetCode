using NUnit.Framework;
using LeetCode;

namespace LeetCodeTest
{
    [TestFixture]
    public class TwoSumTest
    {
        [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [TestCase(new[] { -3, 4, 3, 90 }, 0, new[] { 0, 2 })]
        [TestCase(new int[] { }, 0, new[] { 0, 0 })]
        public void TestTwoSum(int[] nums, int target, int[] expected)
        {
            var twoSum = new TwoSum(); ;
            var actual = twoSum.GetTwoSum(nums, target);
            Assert.AreEqual(expected, actual);
        }
    }
}

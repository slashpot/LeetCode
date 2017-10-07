using LeetCode;
using NUnit.Framework;

namespace LeetCodeTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestEmptyArray()
        {
            var containsDuplicate = new ContainsDuplicateIII();
            var actual = containsDuplicate.ContainsNearbyAlmostDuplicate(new int[0], 0, 0);
            Assert.AreEqual(false, actual);
        }

        [TestCase(new[] { -1, -1 }, 1, 0, true)]
        [TestCase(new[] { -1, 2147483647 }, 1, 2147483647, false)]
        [TestCase(new[] { 1, 3, 1 }, 2, 1, true)]
        [TestCase(new[] { 1, 2 }, 0, 1, false)]
        [TestCase(new[] { 7, 1, 3 }, 2, 3, true)]
        public void TestNormalCases(int[] nums, int k, int t, bool expected)
        {
            var containsDuplicate = new ContainsDuplicateIII();
            var actual = containsDuplicate.ContainsNearbyAlmostDuplicate(nums, k, t);
            Assert.AreEqual(expected, actual);
        }
    }
}
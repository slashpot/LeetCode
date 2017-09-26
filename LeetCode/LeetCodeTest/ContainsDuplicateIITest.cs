using NUnit.Framework;

namespace LeetCodeTest
{
    [TestFixture]
    public class ContainsDuplicateIITest
    {
        [Test]
        public void Empty_Array_Test()
        {
            var input = new int[] { };
            Assert.IsFalse(LeetCode.ContainsDuplicateII.ContainsNearbyDuplicate(input, 0));
        }

        [TestCase(new[] {3,4,2,5,9,2}, 4)]
        public void Normal_Array_Test(int[] input, int k)
        {
            Assert.IsTrue(LeetCode.ContainsDuplicateII.ContainsNearbyDuplicate(input, k));
        }
    }
}
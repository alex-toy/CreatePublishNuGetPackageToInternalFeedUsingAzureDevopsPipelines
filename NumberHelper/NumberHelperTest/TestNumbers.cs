using NumberHelper;
using System;
using Xunit;

namespace NumberHelperTest
{
    public class TestNumbers
    {
        [Fact]
        public void ShouldSumEvens()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int actual = Calculator.SumEvens(nums);
            Assert.Equal(12, actual);
        }
    }
}

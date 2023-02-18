using System;

namespace NumberHelper
{
    public class Calculator
    {
        public static int SumEvens(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0) sum += nums[i];
            }

            return sum;
        }

        public static int SumOdds(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0) sum += nums[i];
            }

            return sum;
        }
    }
}

using System;

namespace CBcanBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 2, 1 };
            int[] nums2 = { 2, 1, 1, 2, 1 };

            bool checkNums = canBalance(nums);
            Console.WriteLine(checkNums); // Should print: True
            bool checkNums2 = canBalance(nums2);
            Console.WriteLine(checkNums2); // Should print: False
        }

        public static bool canBalance(int[] nums)
        {
            // Iterate through each possible split point
            for (int i = 1; i < nums.Length; i++)
            {
                int sum1 = 0;
                int sum2 = 0;

                // Calculate the sum of the first part
                for (int j = 0; j < i; j++)
                {
                    sum1 += nums[j];
                }

                // Calculate the sum of the second part
                for (int j = i; j < nums.Length; j++)
                {
                    sum2 += nums[j];
                }

                // Check if the two sums are equal
                if (sum1 == sum2)
                {
                    return true;
                }
            }

            // If no split point is found that balances the array, return false
            return false;
        }
    }
}

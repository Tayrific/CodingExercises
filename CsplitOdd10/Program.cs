namespace CsplitOdd10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 5, 5, 6 };
            Console.WriteLine(splitOdd10(nums,0,0,0)); // Output: true
        }

        static bool splitOdd10(int[] nums, int index, int sum1, int sum2)
        {
            if (index >= nums.Length)
            {
                // Base case: check if one group's sum is a multiple of 10 and the other group's sum is odd
                return (sum1 % 10 == 0 && sum2 % 2 != 0) || (sum2 % 10 == 0 && sum1 % 2 != 0);
            }

            // Include the current number in the first group
            if (splitOdd10(nums, index + 1, sum1 + nums[index], sum2))
            {
                return true; // If true is returned, we found a valid split
            }

            // Include the current number in the second group
            if (splitOdd10(nums, index + 1, sum1, sum2 + nums[index]))
            {
                return true; // If true is returned, we found a valid split
            }

            return false; // If neither case works, return false
        }
    }
}

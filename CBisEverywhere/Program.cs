using System.Globalization;

namespace CBisEverywhere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 1, 3};

            bool check1 = isEverywhere(nums, 1);
            Console.WriteLine(check1);

            bool check2 = isEverywhere(nums, 2);
            Console.WriteLine(check2);
        }

        public static Boolean isEverywhere(int[] nums,int val)
        {
           for (int i = 0; i < nums.Length-1; i++) //loops through array
            {
                if (nums[i] != val && nums[i + 1] != val) //checks if either the current number or the next number (pairs) match the val
                { 
                    return false;
                }
            }
            return true;
        }
    }
}

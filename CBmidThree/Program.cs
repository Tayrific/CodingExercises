namespace CBmidThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints1 = { 8, 2, 3, 5, 7 };
            int[] ints2 = { 8, 12, 7, 8, 9, 2, 4 };
            int[] ints3 = { 8, 12, 7, 8, 9, 2};

            Console.WriteLine("-------------------");
            Console.WriteLine("- mid 3 of Array 1 -");
            Console.WriteLine("-------------------");
            DisplayMiddleThree(ints1);
            Console.WriteLine("-------------------");
            Console.WriteLine("- mid 3 of Array 2 -");
            Console.WriteLine("-------------------");
            DisplayMiddleThree(ints2);
            Console.WriteLine("-------------------");
            Console.WriteLine("- mid 3 of Array 3 -");
            Console.WriteLine("-------------------");
            DisplayMiddleThree(ints3);
        }

        public static int[]? MidThree(int[] nums)
        {
            int[] three = new int[2];


            if (nums.Length % 2 == 0 || nums.Length < 3)
            {
                return null; // Return null if the array length is even or less than 3
            }
            else 
            {
                int mid = (nums.Length) / 2; //finds middle number
                return new int[] { nums[mid - 1], nums[mid], nums[mid + 1] }; //returns mid three
            }
            


        }

        public static void DisplayMiddleThree(int[] nums)
        {
            int[] result = MidThree(nums); 
            
            if (result != null)
            {
                
                foreach (int num in result) //displays middle 3 values
                {
                    Console.Write(num + " "); 
                }
            }
            else //if array length is too small or is even
            {
                Console.WriteLine("The array length is less than 3 or the length is an even number (does not have 3 middle values).");
            }

            Console.WriteLine(" ");
            
        }
    }
}

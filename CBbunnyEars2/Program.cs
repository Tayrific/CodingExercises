namespace CBbunnyEars2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4; // Example number of bunnies
            int totalEars = CountBunnyEars(n);
            Console.WriteLine("Total ears for {0} bunnies: {1}", n, totalEars);
        }

        public static int CountBunnyEars(int n)
        {
            if (n == 0)
            { 
                return 0; //no bunnies
            }

            if (n % 2 == 1)
            {            
                return 2 + CountBunnyEars(n - 1); // Add 2 for odd bunny then recursively call for next bunny
            }
            else
            {          
                return 3 + CountBunnyEars(n - 1); // Add 3 for even bunny then recursively call for next bunny
            }

        }
    }
}

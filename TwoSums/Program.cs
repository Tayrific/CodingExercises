namespace TwoSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 3, 1, 5, 7, 6, 9 }; 
            int target = 10;

            var result = FindTwoSum(numbers, target);

            if (result == null)
            {
                Console.WriteLine("no pairs");
            }
            else
            {
                Console.WriteLine($"Indices of the two numbers: {result.Item1}, {result.Item2}");
            }
           
        }
        public static Tuple<int, int>? FindTwoSum(List<int> nums, int target)
        {
            for (int i = 0; i < nums.Count; i++) //nested loop checking each pair
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[i] + nums[j] == target) //checking if they add to equal the target
                    {
                        return Tuple.Create(i, j); //returns results
                    }
                }
            }

            return null; //null if no pairs
        }

    }
}

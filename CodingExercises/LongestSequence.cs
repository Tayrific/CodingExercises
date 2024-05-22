namespace CodingExercises
{
    internal class LongestSequence
    {
        static void Main(string[] args)
        {
            List<int> sequence = new List<int> {1,2,1,1,0,3,1,0,0,2,3,1,0,0,0,0,2,1,0,3,1,0,0,0,6,1,3,0,0,0};
            Console.WriteLine("Longest sequence of days without sale: {0}",longestSeq(sequence));
            Console.ReadLine();
            
        }

        static int longestSeq(List<int> sequence)
        {
            int max = 0;
            int current = 0;

            foreach (int num in sequence)
            {
                if (num == 0) {
                    current++;
                    if (current > max) {
                        max = current;
                    }
                } else {
                    current = 0;
                }
            }

            return max;
        }
    }
}

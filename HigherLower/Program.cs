namespace HigherLower
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Find the number between 1-99");

            Random rng = new Random();
            int rand = rng.Next(100); // number between 0 and 99
            
            GuessNumber(rand);

        }

        public static void GuessNumber(int rand)
        {
            int input = 0;
            int guesses = 6;

            while (guesses > 0 && input != rand)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Guess a number: "); // user guesses number
                Console.WriteLine(" ");
                input = Convert.ToInt32(Console.ReadLine());
                guesses--;

                if (rand > input) //deciding if the random number is higher or lower
                {
                    Console.WriteLine("The number is higher");
                }
                else if (rand < input)
                {
                    Console.WriteLine("The number is lower");
                }
            }

            if (input == rand)
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("You lost!");
            }

        }
    }
}

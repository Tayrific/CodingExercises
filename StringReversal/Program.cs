using System.Text;

namespace StringReversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("enter a string you would like in reverse: ");
            input = Console.ReadLine();

            //reversing string

            StringBuilder reverse = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--) //starting at the last char
            {
                reverse.Append(input[i]); //adding the char to stringBuilder
            }

            string reversedInput = reverse.ToString();
            Console.WriteLine(reversedInput); //output reversed

        }
    }
}

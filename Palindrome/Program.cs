using System.Text;

namespace Palindrome
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

            // checks if reversed and input and outputs wether palindrome or not
            if (reversedInput == input) 
            {
                Console.WriteLine("is palindrome");

            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }



        }
    }
}

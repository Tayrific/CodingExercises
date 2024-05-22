namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i, sum = 0;

            Console.WriteLine("----- Sum Of Digits -----");
            Console.WriteLine("enter a number: ");

            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------");

            Console.WriteLine("---- using a for loop ----");

            
            string inputString = input.ToString();

            for (i = 0; i < inputString.Length; i++) //for loop used to go through each digit
            {
                int digit = Convert.ToInt32(inputString[i].ToString()); // Convert character to integer
                sum += digit;
            }

            Console.WriteLine("Sum of digits: " + sum);

            Console.WriteLine("--------------------------");

            Console.WriteLine("--- using a while loop ---");

            i = 0;
            sum = 0;
            while(i< inputString.Length)
            {
                int digit = Convert.ToInt32(inputString[i].ToString()); // Convert character to integer
                sum += digit;
                i++;
            }

            Console.WriteLine("Sum of digits: " + sum);




        }
    }
}

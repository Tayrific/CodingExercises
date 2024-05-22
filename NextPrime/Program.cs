namespace NextPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool prime = false;

            Console.Write("Pick a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0 || num == 1)
                Console.WriteLine(2); //no negative prime numbers and neither are 0 or 1
            else
            {
                int newNum = num + 1;
                while (prime == false) // while loop checks numbers in ascending order
                {

                    for (int i = 2; i < newNum; i++)
                        if (newNum % i == 0) //checks if prime as no remainders when it is divided.
                        {
                            newNum++; //if its prime the number will go up by 1
                        }
                        else
                        {
                            prime = true;
                        }
                }

                Console.WriteLine(newNum); // prints new number

            }
        }
    }
}

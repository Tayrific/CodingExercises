using System;
using System.Collections.Generic;

namespace Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> primes = primeNumbers(100); //generating 100 prime numbers
            int input;

            Console.WriteLine("Enter which Nth prime number you would like (under 100): ");
            input = Convert.ToInt32(Console.ReadLine()); 

            if (input > 100 || input < 1) //validating that input is a acceptable response
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
            }
            else
            {
                Console.WriteLine("The prime number in position {0} is {1} ", input, primes[input - 1]);
            }
        }

        static List<int> primeNumbers(int maxNum) //creating a list of 100 prime numbers
        {
            List<int> primes = new List<int>();

            int number = 2;
            while (primes.Count < maxNum + 1)
            {
                if (IsPrime(number)) //calling function to chekc if number is prime
                {
                    primes.Add(number);
                }
                number++;
            }

            return primes;
        }

        static bool IsPrime(int number)
        {
            if (number < 2) // 2 is first prime number
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++) //checking upto the square root
            {
                if (number % i == 0) // prime numbers will always have remainders when divided
                {
                    return false;
                }
            }
            return true;
        }
    }
}
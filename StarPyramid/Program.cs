namespace StarPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, space, star;

            Console.Write("How many rows: ");
            row = Convert.ToInt32(Console.ReadLine()); //number of rows that will display

            Console.WriteLine("*STAR PYRAMID*");

            for (int i = 1; i <= row; i++) //loop for each row
            {
                for (space = 1; space <= row - i; space++) //loop to add spaces
                    Console.Write(" ");


                for (star = 1; star <= 2 * i - 1; star++) //loop to add the asteriks
                    Console.Write("*");

                Console.Write("\n");  //go to next line
            }
        }
    }
}

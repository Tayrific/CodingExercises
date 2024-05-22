using System.Collections;
using System.Text;

namespace Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows;

            Console.Write("How mant rows rows (half of the diamond): ");
            rows = Convert.ToInt32(Console.ReadLine());

            //stringBuilder object
            ArrayList diamond = new ArrayList();

            // upper half including the middle line
            for (int i = 1; i <= rows; i++)
            {
                StringBuilder line = new StringBuilder();
                for (int space = 1; space <= rows - i; space++) //loop to add spaces
                    line.Append(" ");

                for (int star = 1; star <= 2 * i - 1; star++) //loop to add stars
                    line.Append("*");

                diamond.Add(line.ToString());
            }

            //lower half
            for (int i = rows - 1; i >= 1; i--)
            {
                StringBuilder line = new StringBuilder();
                for (int space = 1; space <= rows - i; space++) //loop to add spaces
                    line.Append(" ");

                for (int star = 1; star <= 2 * i - 1; star++) //loop to add stars
                    line.Append("*");

                diamond.Add(line.ToString());
            }


            foreach (Object line in diamond)
            {
                Console.WriteLine(line);
            }

        }
    }
}

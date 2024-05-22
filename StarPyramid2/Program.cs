using System.Collections;
using System.Text;

namespace StarPyramid2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row,space,star;

            Console.Write("How many rows: ");
            row = Convert.ToInt32(Console.ReadLine());

            ArrayList pyramid = new ArrayList();
            for (int i = 1; i <= row; i++) //loop for each row
            {
                StringBuilder line = new StringBuilder(); //stringBuilder object

                for (space = 1; space <= row - i; space++) //loop to add spaces, append adds to the end of string
                    line.Append(" ");


                for (star = 1; star <= 2 * i - 1; star++) //loop to add the asteriks
                    line.Append("*");

                pyramid.Add(line.ToString());  //adds to array list
            }


            foreach (Object line in pyramid)
            {
                Console.WriteLine(line); //print array list
            }
        }

    }
}

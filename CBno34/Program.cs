namespace CBno34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string> { "a", "bb", "ccc", "dddd","eeeee" };

            List<string> newList = no34(myList);

            foreach (string word in newList)
            {
                
            }        

        }

        public static List<string> no34(List<string> words)
        {
            List<string> listNo34 = new List<string> { };

            foreach (string word in words)
            {
                switch (word.Length) //switch case used to check for length 3 or 4
                {
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        listNo34.Add(word); // add the rest of the lengthed to the array
                        break;
                }
            }

            foreach (string word in listNo34)
            {
                Console.WriteLine(word);
            }
            return listNo34;
            
        }
    }
}

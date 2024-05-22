namespace Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anagrams for the word star");
            List<string> words = new List<string>
            {
                "parts", "traps", "arts", "rats", "starts", "tarts",
                "rat", "art", "tar", "tars", "stars", "stray"
            };

            string myWord = "star";
            char[] sortedWord = myWord.ToCharArray();

            Array.Sort(sortedWord);
            string sortedWordString = new string(sortedWord);

            foreach (string word in words)
            {
                char[] sortWord = word.ToCharArray();
                Array.Sort(sortWord);
                string SortWordString = new string(sortWord);

                if (sortedWordString == SortWordString)
                {
                    Console.WriteLine(word);
                }
                
            }
        }
    }
}

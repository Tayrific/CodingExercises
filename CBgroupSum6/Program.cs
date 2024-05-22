namespace CBgroupSum6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 5, 6, 2 };
            Console.WriteLine(GroupSum6(0, ints, 7));
           
           
        }

        public static bool GroupSum6(int start, int[] ints, int target)
        {
            if (start == ints.Length)
            { 
                if (target ==0)
                {
                    return true;
                } else
                {
                    return false;
                }
            }

            if (ints[start] == 6)
            { return GroupSum6(start + 1, ints, target - 6); }

            if (GroupSum6(start + 1, ints, target - ints[start]))
            { return true; }

            if (GroupSum6(start + 1, ints, target))
            { return true; }

            return false;

        }
    }
}

using System;

namespace RemoveDupplicateArrayElement
{
    class Program
    {
        public static void Main(string[] arg)
        {
            int[] a = [10, 1, 2, 3, 9, 4, 4, 4, 5, 5, 5, 5, 6, 7, 8, 8];
            //hashset avoids duplicate values
            HashSet<int> hs = a.ToHashSet<int>();
            foreach (int x in hs)
            {
                System.Console.WriteLine(x);
            }
        }
    }
}
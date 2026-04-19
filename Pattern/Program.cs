using System;

namespace Pattern
{
    class Program
    {
        static void Main(string[] arg)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++ )
                {
                    System.Console.Write(j);
                }
            System.Console.WriteLine();
            }
        }
    }
}
/*
output
1
12
123
1234
12345
*/
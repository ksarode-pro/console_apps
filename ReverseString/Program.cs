using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace ReverseString
{
    static class Program
    {
        public static void Main(string[] args)
        {
            string name = "Kiran Suresh Sarode";
            System.Console.WriteLine(ReverseString(name));
            System.Console.WriteLine(name.ReverseStringPro());
            System.Console.WriteLine(name.ReverseStringProMax());
        }

        private static string ReverseString(string name)
        {
            char[] chars = name.ToArray();
            char[] charsReverse = new char[chars.Length];
            int j = 0;
            for(int i = chars.Length - 1; i >= 0; i--)
            {
                charsReverse[j] = chars[i];
                j++;
            }
            return new string(charsReverse);
        }

        private static string ReverseStringPro(this string name)
        {
            char[] chars = name.ToArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        private static string ReverseStringProMax(this string name)
        {
            char[] chars = name.ToArray();
            int len = chars.Length;
            int ptr = 0;
            char temp;
            while(ptr < len/2)
            {
                temp = chars[ptr];
                chars[ptr] = chars[len-(ptr+1)];
                chars[len-(ptr+1)] = temp;
                ptr++;
            }
            return new string(chars);
        }
    }
}
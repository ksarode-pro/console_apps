using System;

namespace ReverseArray
{
    //Program to reverse array
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 11, 12, 13, 14, 15, 16 };
            PrintArray(arr);
            int[] rev_arr = ReverseArray(arr);
            PrintArray(rev_arr);
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine("Reversed Array elements: ");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] ReverseArray(int[] arr)
        {
            Console.WriteLine("Array elements: ");
            int temp;
            for (int x = 0; x < Convert.ToInt32(arr.Length / 2); x++)
            {
                //select last element
                temp = arr[arr.Length - (x + 1)];

                //check if mid point should not be crossed
                if (x < (arr.Length - (x + 1)))
                {
                    arr[arr.Length - (x + 1)] = arr[x];
                    arr[x] = temp;
                }
            }
            return arr;

        }
    }
}
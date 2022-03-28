using System;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            Add(ref array);

        }
        public static void Add(ref int [] array)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = 1;
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }

        }
    }
}

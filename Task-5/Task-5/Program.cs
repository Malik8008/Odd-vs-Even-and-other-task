using System;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {12,15,18,24,45 };
            AddArr(ref array);
        }

        public static void AddArr( ref int [] array)
        {
            Array.Resize(ref array, array.Length+1);            
            foreach (var add in array)
            {
                array[array.Length - 1] = 55;
                Console.WriteLine(add);
            }
        }
    }
}

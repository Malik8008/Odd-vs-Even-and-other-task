using System;

namespace Odd_vs_Even_Opp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsOdd(12));
            Console.WriteLine(IsEven(12));  
        }
        public static bool IsOdd(int num)
        {
            return num % 2 == 1;
        }
        public static bool IsEven(int num)
        {
            return num % 2 == 0;  

        }
    }
}

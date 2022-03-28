using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BigR("Salam1"));
        }

        public static bool BigR(string check)
        {
            bool HasDigit = false;
            bool HasUpper = false;
            bool Haslower = false;

            foreach (char letter in check)
            {
                if (char.IsDigit(letter))
                {
                    HasDigit = true;
                    continue; 
                }
                if (char.IsUpper(letter))
                {
                    HasUpper = true;
                    continue;
                }
                if (char.IsLower(letter))
                {
                    Haslower = true;                    
                }               
            }
            bool result = HasDigit && HasUpper && Haslower;
            return result;
        }               
    }
}

using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstWorld("Hello ey zalim dunya necesen?");
        }

        public static void FirstWorld(string sentence)
        {            
            Console.WriteLine(sentence.Substring(0,sentence.IndexOf(' ')));
        }
    }
}

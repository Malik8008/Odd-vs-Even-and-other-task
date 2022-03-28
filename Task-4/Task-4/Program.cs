using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstBigWorld("Elon Musk"));
        }

        public static bool FirstBigWorld(string sentence)
        {
            int word=0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (char.IsUpper(sentence[i]) && i==0)
                {
                    word++;
                }
                else if (char.IsWhiteSpace(sentence[i]))
                {
                    word++;
                    if (char.IsUpper(sentence[i + 1]))
                    {
                        word++;
                    }
                }
            }
            return word==3? true:false;
        }
    }
}

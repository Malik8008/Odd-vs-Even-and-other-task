using System;

namespace Homework_TASK_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student();
            

            Console.WriteLine("Ad ve Soyad daxil edin");
            string fn=Console.ReadLine();                       
            Console.WriteLine("Group No daxil edin");
            string gn=Console.ReadLine();
            byte number = 21;
            Console.WriteLine($"Telebenin yashi: {number}");

            student.age = number;
            student.CheckFullName = fn;
            student.CheckGroupNo = gn;
        }       
    }
}

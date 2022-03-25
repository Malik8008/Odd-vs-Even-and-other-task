using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_TASK_2
{
    internal class Student
    {
        private string  _groupno;
        private string _fullname;
        public byte age;
        public  string CheckGroupNo
        {
            get
            {
                return _groupno;
            }
            set
            {
                while (!CheckNo(value))
                {
                    Console.WriteLine("Duzgun Group no daxil edin.\n");
                    value = Console.ReadLine();
                }
                Console.WriteLine("Group no qeyde alindi.\n");

                _groupno = value;
            }
        }

        public  string CheckFullName {
            get
            {
                return _fullname;
            }
            set
            {
                while (!CheckFull(value))
                {
                    Console.WriteLine("Duzgun Ad ve Soyad qeyd edin.\n");
                    value = Console.ReadLine();
                }
                Console.WriteLine("Ad ve Soyad qeyde alindi.\n");
                _fullname = value;
            }
        }        
        public static bool CheckNo(string groupno)
        {
            if (groupno.Length==4)
            {
                bool HasDigit = false;
                bool HasUpper = false;
                
                foreach (char filter in groupno)
                {
                    if (char.IsDigit(filter))
                    {
                        HasDigit = true;
                        continue;
                    }
                    if (char.IsUpper(filter))
                    {
                        HasUpper = true;                        
                    }                    
                }
                bool result = HasUpper && HasDigit;
                return result;
            }            
            return false;
            
        }
        public static bool CheckFull(string fullname)
        {
            int count = 0;
            for (int i = 0; i < fullname.Length; i++)
            {
                if (char.IsUpper(fullname[i]) && i == 0)
                {
                    count++;
                }
                else if (char.IsWhiteSpace(fullname[i]))
                {
                    count++;
                    if (char.IsUpper(fullname[i + 1]))
                    {
                        count++;
                    }
                }
            }

            return count == 3 ? true : false;
        }
    }
}

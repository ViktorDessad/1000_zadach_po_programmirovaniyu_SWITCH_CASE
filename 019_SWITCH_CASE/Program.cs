using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год");
            Console.Write("Год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            
            switch (year % 10)
            {
                case 0:
                case 1:
                    Console.Write("год бел");
                    break;
                case 2:
                case 3:
                    Console.Write("год черн");
                    break;
                case 4:
                case 5:
                    Console.Write("год зелен");
                    break;
                case 6:
                case 7:
                    Console.Write("год красн");
                    break;
                case 8:
                case 9:
                    Console.Write("год желт");
                    break;
            }
            switch (year % 12)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 9:
                case 10:
                case 11:
                    Console.Write("ой ");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write("ого ");
                    break;
            }
            switch ((year+8)%12)
            {
                case 0:
                    Console.WriteLine("крысы");
                    break;
                case 1:
                    Console.WriteLine("коровы");
                    break;
                case 2:
                    Console.WriteLine("тигра");
                    break;
                case 3:
                    Console.WriteLine("зайца");
                    break;
                case 4:
                    Console.WriteLine("дракона");
                    break;
                case 5:
                    Console.WriteLine("змеи");
                    break;
                case 6:
                    Console.WriteLine("лошади");
                    break;
                case 7:
                    Console.WriteLine("овцы");
                    break;
                case 8:
                    Console.WriteLine("обезьяны");
                    break;
                case 9:
                    Console.WriteLine("курицы");
                    break;
                case 10:
                    Console.WriteLine("собаки");
                    break;
                case 11:
                    Console.WriteLine("свиньи");
                    break;
            }
        }
    }
}

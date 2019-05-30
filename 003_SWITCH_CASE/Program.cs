using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1-12");
            byte number = Convert.ToByte(Console.ReadLine());

            if (number >= 1 && number <= 12)
            {
                switch (number)
                {
                    case 1:
                    case 2:
                        Console.WriteLine("Winter");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Spring");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Summer");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Autumn");
                        break;
                    case 12:
                        goto case 1;
                        
                }

            }
            else
            {
                Console.WriteLine("Error 404");
            }
        }
    }
                        
}

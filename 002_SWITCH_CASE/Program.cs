using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести число от 1 до 5");
            byte num = Convert.ToByte(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Плохо");
                    break;
                case 2:
                    Console.WriteLine("Неудовлетворительно");
                    break;
                case 3:
                    Console.WriteLine("Удовлетворительно");
                    break;
                case 4:
                    Console.WriteLine("Хорошо");
                    break;
                case 5:
                    Console.WriteLine("Отлично");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
    }
}

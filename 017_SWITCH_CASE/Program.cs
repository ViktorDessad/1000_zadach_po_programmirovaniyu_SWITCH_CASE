using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            number:
            Console.WriteLine("Введите число учебных заведений");
            byte number = Convert.ToByte(Console.ReadLine());

            if (number >= 20 && number <= 40)
            {
                //24
                byte secondNumber = (byte)(number % 10);                 //4
                byte firstNumber = (byte)((number - secondNumber) / 10); //2

                switch (firstNumber)
                {
                    case 2:
                        Console.Write($"{number} - двадцать ");
                        break;
                    case 3:
                        Console.Write($"{number} - тридцать ");
                        break;
                    case 4:
                        Console.Write($"{number} - сорок");
                        break;
                }
                switch (secondNumber)
                {
                    case 0:
                        Console.WriteLine("учебных заданий");
                        break;
                    case 1:
                        Console.WriteLine("одно учебное заведение");
                        break;
                    case 2:
                        Console.WriteLine("два учебных заданий");
                        break;
                    case 3:
                        Console.WriteLine("три учебных заданий");
                        break;
                    case 4:
                        Console.WriteLine("четыри учебных заданий");
                        break;
                    case 5:
                        Console.WriteLine("пять учебных заданий");
                        break;
                    case 6:
                        Console.WriteLine("шесть учебных заданий");
                        break;
                    case 7:
                        Console.WriteLine("семь учебных заданий");
                        break;
                    case 8:
                        Console.WriteLine("восемь учебных заданий");
                        break;
                    case 9:
                        Console.WriteLine("девять учебных заданий");
                        break;
                }
            }
            else if (number >= 10 && number <= 19)
            {
                switch (number)
                {
                    case 10:
                        Console.WriteLine($"{number} - десять учебных заданий");
                        break;
                    case 11:
                        Console.WriteLine($"{number} - одинадцать учебных заданий");
                        break;
                    case 12:
                        Console.WriteLine($"{number} - двенадцать учебных заданий");
                        break;
                    case 13:
                        Console.WriteLine($"{number} - тринадцать учебных заданий");
                        break;
                    case 14:
                        Console.WriteLine($"{number} - четырнадцать учебных заданий");
                        break;
                    case 15:
                        Console.WriteLine($"{number} - пятнадцать учебных заданий");
                        break;
                    case 16:
                        Console.WriteLine($"{number} - шестнадцать учебных заданий");
                        break;
                    case 17:
                        Console.WriteLine($"{number} - семнадцать учебных заданий");
                        break;
                    case 18:
                        Console.WriteLine($"{number} - восемнадцать учебных заданий");
                        break;
                    case 19:
                        Console.WriteLine($"{number} - девятнадцать учебных заданий");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error");
                goto number;
            }
        }
    }
}

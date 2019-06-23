using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            age:
            Console.WriteLine("What is your age?");
            Console.Write("My age is: ");
            byte age = Convert.ToByte(Console.ReadLine());

            if (age >= 20 && age <= 69)
            {
                // 23
                byte secondNumber = (byte)(age % 10);                 // 3
                byte firstNumber = (byte)((age - secondNumber) / 10); // 2

                switch (firstNumber)
                {
                    case 2:
                        Console.Write($"{age} - twenty ");
                        break;
                    case 3:
                        Console.Write($"{age} - thirty ");
                        break;
                    case 4:
                        Console.Write($"{age} - fourty ");
                        break;
                    case 5:
                        Console.Write($"{age} - fifty ");
                        break;
                    case 6:
                        Console.Write($"{age} - sixty ");
                        break;
                }

                switch (secondNumber)
                {
                    case 0:
                        Console.WriteLine("years old");
                        break;
                    case 1:
                        Console.WriteLine("one years old");
                        break;
                    case 2:
                        Console.WriteLine("two years old");
                        break;
                    case 3:
                        Console.WriteLine("three years old");
                        break;
                    case 4:
                        Console.WriteLine("four years old");
                        break;
                    case 5:
                        Console.WriteLine("five years old");
                        break;
                    case 6:
                        Console.WriteLine("six years old");
                        break;
                    case 7:
                        Console.WriteLine("seven years old");
                        break;
                    case 8:
                        Console.WriteLine("eihgt years old");
                        break;
                    case 9:
                        Console.WriteLine("one years old");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error");
                goto age;
            }
        }
    }
}

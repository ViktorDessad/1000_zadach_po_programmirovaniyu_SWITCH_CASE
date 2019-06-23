using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {   
            num:
            Console.WriteLine("Enter number from 100 to 999");
            short num = Convert.ToInt16(Console.ReadLine());
                                                                                        //123
            short thirdNumber = (short)(num % 10);                                      // 3
            short secondNumber = (short)((num % 100 - thirdNumber) / 10);               // 2
            short firstNumber = (short)((num - thirdNumber - secondNumber * 10) / 100); // 1

            if (num >= 100 && num <= 999)
            {
                switch (firstNumber)
                {
                    case 1:
                        Console.Write($"{num} - сто ");
                        break;
                    case 2:
                        Console.Write($"{num} - двесте ");
                        break;
                    case 3:
                        Console.Write($"{num} - триста ");
                        break;
                    case 4:
                        Console.Write($"{num} - четыриста ");
                        break;
                    case 5:
                        Console.Write($"{num} - пятсот ");
                        break;
                    case 6:
                        Console.Write($"{num} - шестьсот ");
                        break;
                    case 7:
                        Console.Write($"{num} - семьсот ");
                        break;
                    case 8:
                        Console.Write($"{num} - восемьсот ");
                        break;
                    case 9:
                        Console.Write($"{num} - девятсот ");
                        break;
                }
                switch (secondNumber)
                {
                    case 2:
                        Console.Write("двадцать ");
                        break;
                    case 3:
                        Console.Write("тридцать ");
                        break;
                    case 4:
                        Console.Write("сорок ");
                        break;
                    case 5:
                        Console.Write("пятьдесят ");
                        break;
                    case 6:
                        Console.Write("шестьдесят ");
                        break;
                    case 7:
                        Console.Write("семдесят ");
                        break;
                    case 8:
                        Console.Write("восемдесят ");
                        break;
                    case 9:
                        Console.Write("девяносто ");
                        break;
                    case 1:
                        switch (num % 100)
                        {
                            case 10:
                                Console.WriteLine("десять");
                                break;
                            case 11:
                                Console.WriteLine("одинадцать");
                                break;
                            case 12:
                                Console.WriteLine("двенадцать");
                                break;
                            case 13:
                                Console.WriteLine("тринадцать");
                                break;
                            case 14:
                                Console.WriteLine("четырнадцать");
                                break;
                            case 15:
                                Console.WriteLine("пятнадцать");
                                break;
                            case 16:
                                Console.WriteLine("шестьнадцать");
                                break;
                            case 17:
                                Console.WriteLine("семнадцать");
                                break;
                            case 18:
                                Console.WriteLine("восемнадцать");
                                break;
                            case 19:
                                Console.WriteLine("девятнадцать");
                                break;
                        }
                        break;
                }
                if ((num % 100/10) != 1)
                {
                    switch (thirdNumber)
                    {
                        case 1:
                            Console.WriteLine("один");
                            break;
                        case 2:
                            Console.WriteLine("два");
                            break;
                        case 3:
                            Console.WriteLine("три");
                            break;
                        case 4:
                            Console.WriteLine("четыри");
                            break;
                        case 5:
                            Console.WriteLine("пять");
                            break;
                        case 6:
                            Console.WriteLine("шесть");
                            break;
                        case 7:
                            Console.WriteLine("семь");
                            break;
                        case 8:
                            Console.WriteLine("восемь");
                            break;
                        case 9:
                            Console.WriteLine("девять");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Error");
                goto num;
            }
        }
    }
}

                

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the locator direction: N,W,S,E");
            char locator = Convert.ToChar(Console.ReadLine());

            if (locator != 'N' && locator != 'W' && locator != 'S' && locator != 'E')
            {
                Console.WriteLine("Error, you can use only N, W, S and E commands");
            }
            else
            {
                Console.WriteLine("Enter first digital command");
                sbyte firstDigitalCommand = Convert.ToSByte(Console.ReadLine());

                if (firstDigitalCommand != 1 && firstDigitalCommand != -1 && firstDigitalCommand != 2)
                {
                    Console.WriteLine("Error, you can use only 1, -1 or 2 commands");
                }
                else
                {
                    Console.WriteLine("Enter second digital command");
                    sbyte secondDigitalCommand = Convert.ToSByte(Console.ReadLine());

                    if (secondDigitalCommand != 1 && secondDigitalCommand != -1 && secondDigitalCommand != 2)
                    {
                        Console.WriteLine("Error, you can use only 1, -1 or 2 commands");
                    }
                    else
                    {
                        switch (firstDigitalCommand)
                        {
                            case 1:
                                Console.WriteLine($"Command - {locator}{firstDigitalCommand}{secondDigitalCommand}");
                                break;
                            case -1:
                                Console.WriteLine($"Command - {locator}{firstDigitalCommand}{secondDigitalCommand}");
                                break;
                            case 2:
                                Console.WriteLine($"Command - {locator}{firstDigitalCommand}{secondDigitalCommand}");
                                break;
                        }
                    }
                }
            }
        }
    }
}

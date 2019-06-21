using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter direction: 0 - move, 1 - turn right or -1 - turn left");
            sbyte move = Convert.ToSByte(Console.ReadLine());
            
            if (move == 1 || move == 0 || move == -1)
            {
                Console.WriteLine("Enter N - north, W - west, S-south, E - east");
                char direction = Convert.ToChar(Console.ReadLine());

                switch (direction)
                {
                    case 'N':
                        Console.WriteLine($"Robot move to {direction}{move}");
                        break;
                    case 'W':
                        Console.WriteLine($"Robot move to {direction}{move}");
                        break;
                    case 'S':
                        Console.WriteLine($"Robot move to {direction}{move}");
                        break;
                    case 'E':
                        Console.WriteLine($"Robot move to {direction}{move}");
                        break;
                }               
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}


            

            

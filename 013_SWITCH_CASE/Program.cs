using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            Elements:
            Console.WriteLine("Enter triangle elements from 1 to 4");
            byte elements = Convert.ToByte(Console.ReadLine());

            if (elements != 1 && elements != 2 && elements != 3 && elements != 4)
            {
                Console.WriteLine("Error");
                goto Elements;
            }
            else
            {
                Console.WriteLine("Enter triangle side");
                uint side = Convert.ToUInt32(Console.ReadLine());

                switch (elements)
                {
                    case 1:
                        Console.WriteLine($"Katet = {side}");
                        break;
                    case 2:
                        Console.WriteLine($"Hypotenuse = {side * Math.Sqrt(2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Height = {(side * Math.Sqrt(2))/2}");
                        break;
                    case 4:
                        Console.WriteLine($"Square = {(side * Math.Sqrt(2) *((side * Math.Sqrt(2)) / 2)) / 2 }");
                        break;
                }
            }

        }
    }
}

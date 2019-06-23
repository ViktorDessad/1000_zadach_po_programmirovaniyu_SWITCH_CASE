using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation:
            Console.WriteLine("Enter operation number from 1 to 4");
            byte operation = Convert.ToByte(Console.ReadLine());

            if (operation >= 1 && operation <= 4)
            {
                Console.WriteLine("Enter triangle side");
                int side = (int)Math.Abs(Convert.ToInt32(Console.ReadLine()));

                double firstRadius = (side * Math.Sqrt(3)) / 6;
                double secondRadius = firstRadius * 2;
                double square = (Math.Pow(side, 2) * Math.Sqrt(3)) / 4;

                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Side = {0}", side);
                        break;
                    case 2:
                        Console.WriteLine("First radius {0}", firstRadius);
                        break;
                    case 3:
                        Console.WriteLine("Second radius {0}", secondRadius);
                        break;
                    case 4:
                        Console.WriteLine("Square {0}", square);
                        break;
                }              
            }
            else
            {
                Console.WriteLine("Error");
                goto Operation;
            }
        }
    }
}

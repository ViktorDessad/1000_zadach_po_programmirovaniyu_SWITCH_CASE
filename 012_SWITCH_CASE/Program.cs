using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter operation number from 1 to 4");
            byte operationNumber = Convert.ToByte(Console.ReadLine());

            if (operationNumber != 1 && operationNumber != 2 && operationNumber != 3 && operationNumber !=4)
            {
                Console.WriteLine("Error, please enter valid operation number: 1, 2, 3  or 4");
            }
            else
            {
                Console.WriteLine("Enter radius");
                uint radius = (uint)Math.Abs(Convert.ToUInt32(Console.ReadLine()));

                switch (operationNumber)
                {
                    case 1:
                        Console.WriteLine($"Radius = {radius}");
                        break;
                    case 2:
                        Console.WriteLine($"Diameter = {2*radius}");
                        break;
                    case 3:
                        Console.WriteLine($"Lenght = {2*Math.PI*radius}");
                        break;
                    case 4:
                        Console.WriteLine($"Circle squre {Math.PI*Math.Pow(radius,2)}");
                        break;
                }
            }
        }
    }
}

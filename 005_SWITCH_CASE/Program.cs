using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 1 to 4");
            byte sign = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter number A");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number B");
            int numberB = Convert.ToInt32(Console.ReadLine());

            switch (sign)
            {
                case 1:
                    Console.WriteLine($" {numberA} * {numberB} = {numberA * numberA} - it's multiplication"); //mul
                    break;
                case 2:
                    Console.WriteLine($"{numberA} / {numberB} = {numberA / numberB} - it's division "); //div
                    break;
                case 3:
                    Console.WriteLine($" {numberA} - {numberB} = {numberA - numberB} - it's subtraction"); // sub
                    break;
                case 4:
                    Console.WriteLine($" {numberA} + {numberB} = {numberA + numberB} - it's subtraction"); // add
                    break;
            }
        }
    }
}
               
               

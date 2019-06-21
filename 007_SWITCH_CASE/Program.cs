using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter weight in kg");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter number from 1 to 5");
            byte num = Convert.ToByte(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine($"Weight in kg = {weight*1}");
                    break;
                case 2:
                    Console.WriteLine($"Weight in mg = {weight * 1000000}");
                    break;
                case 3:
                    Console.WriteLine($"Weight in gr = {weight * 1000}");
                    break;
                case 4:
                    Console.WriteLine($"Weight in t = {weight * 0.001}");
                    break;
                case 5:
                    Console.WriteLine($"Weight in mg = {weight * 0.01}");
                    break;
            }
        }
    }
}

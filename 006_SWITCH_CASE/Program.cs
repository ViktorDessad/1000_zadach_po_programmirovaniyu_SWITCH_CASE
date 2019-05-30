using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 1 to 5");
            byte number = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter line length in meter: ");
            double length = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:// decimeter
                    double resInDec = length * 10;
                    Console.WriteLine("The result in decimeter {1} in {0} meter",length, resInDec);
                    break;
                case 2:
                    double resInKilo = length / 1000;
                    Console.WriteLine("The result is kilometer {1} in {0} meter",length, resInKilo);
                    break;
                case 3:
                    Console.WriteLine("The result is {0} meter", length);
                    break;
                case 4:
                    double resInMili = length * 1000;
                    Console.WriteLine("The result is milimeter {1} in {0} meter", length, resInMili);
                    break;
                case 5:
                    double resInSanti = length * 100;
                    Console.WriteLine("The result is santimeter {1} in {0} meter", length, resInSanti);
                    break;
                default:
                    break;
            }
        }
    }
}

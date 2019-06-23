using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_SWITCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the card suit from 1 to 4");
            byte cardSuit = Convert.ToByte(Console.ReadLine());

            if (cardSuit >= 1 && cardSuit <= 4)
            {
                Console.WriteLine("Enter the card number");
                byte cardNumber = Convert.ToByte(Console.ReadLine());

                if (cardNumber >= 6 && cardNumber <= 14)
                {
                    switch (cardNumber)
                    {
                        case 6:
                            Console.Write("Six ");
                            break;
                        case 7:
                            Console.Write("Seven ");
                            break;
                        case 8:
                            Console.Write("Eight ");
                            break;
                        case 9:
                            Console.Write("Nine ");
                            break;
                        case 10:
                            Console.Write("Ten ");
                            break;
                        case 11:
                            Console.Write("Jack ");
                            break;
                        case 12:
                            Console.Write("Queen ");
                            break;
                        case 13:
                            Console.Write("King ");
                            break;
                        case 14:
                            Console.Write("Ace ");
                            break;
                    }
                    switch (cardSuit)
                    {
                        case 1:
                            Console.WriteLine("spade");
                            break;
                        case 2:
                            Console.WriteLine("club");
                            break;
                        case 3:
                            Console.WriteLine("diamond");
                            break;
                        case 4:
                            Console.WriteLine("heart");
                            break;
                    }

                }
            }
        }
    }
}

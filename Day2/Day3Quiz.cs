using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Day3Quiz
    {
        static void Main()
        {
            Console.WriteLine("Welcome to ISS Gadget Shop");
            Console.WriteLine("Please enter number of gadgets to purchase:");
            int number = Int32.Parse(Console.ReadLine());
            double totalCost = number * 500;
            Console.WriteLine("Number of items to purchase:{0}", number);
            if(totalCost<=2000)
            {

            }
            else if(totalCost<=3000)
            {
                totalCost = 0.97 * totalCost;
            }
            else if(totalCost<=6000)
            {
                totalCost = 0.95 * totalCost;
            }
            else if(totalCost>6000)
            {
                totalCost = 0.92 * totalCost;
            }
            else
            {
                Console.WriteLine("Please reenter number of gadgets to purchase as a positive integer.");
            }
            Console.WriteLine("Please pay {0:C}", totalCost);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Question5
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            double x = Double.Parse(Console.ReadLine());
            double formula = 5 * x * x - 4 * x + 3;
            Console.WriteLine(formula);
        }
    }
}

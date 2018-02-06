using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Question2
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            double x = Double.Parse(Console.ReadLine());
            double sqrt = Math.Sqrt(x);
            Console.WriteLine("The square root of {0} = {1:0.000}", x, sqrt);
        }
    }
}

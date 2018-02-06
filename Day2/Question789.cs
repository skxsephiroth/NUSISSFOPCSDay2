using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Question789
    {
        static void Main()
        {
            Console.WriteLine("Please enter distance travelled:");
            double distance = Double.Parse(Console.ReadLine());
            double fare = 2.40 + distance * 0.4;
            Console.WriteLine(fare); //Q7
            Console.WriteLine("{0:0.00}", Math.Round(fare, 1)); //Q8
            Console.WriteLine(Math.Ceiling(Math.Round(fare, 2) * 10) / 10); //Q9
        }
    }
}

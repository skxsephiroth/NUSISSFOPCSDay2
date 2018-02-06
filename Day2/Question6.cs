using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Question6
    {
        static void Main()
        {
            Console.WriteLine("Please enter the x coordinate of the first point:");
            double x1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the y coordinate of the first point:");
            double y1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the x coordinate of the second point:");
            double x2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the y coordinate of the second point:");
            double y2 = Double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2 - y1, 2));
            Console.WriteLine(distance);
        }
    }
}

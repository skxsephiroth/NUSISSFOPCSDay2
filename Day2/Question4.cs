using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Question4
    {
        static void Main()
        {
            Console.WriteLine("Please enter a temperature in Centigrade:");
            double temperatureInC = Double.Parse(Console.ReadLine());
            double temperatureInF = 1.8 * temperatureInC + 32;
            Console.WriteLine("{0}", temperatureInF);
        }
    }
}

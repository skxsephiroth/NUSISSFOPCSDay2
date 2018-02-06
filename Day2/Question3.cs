using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Question3
    {
        static void Main()
        {
            Console.WriteLine("Please enter your salary:");
            double salary = Double.Parse(Console.ReadLine());
            double TotalIncome = 1.13 * salary;
            Console.WriteLine("{0:C}", TotalIncome);
        }
    }
}

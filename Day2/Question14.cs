using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Question14
    {
        static void Main()
        {
            Console.WriteLine("Please enter distance travelled in kilometres:");
            double distance = Double.Parse(Console.ReadLine());
            double roundUpDistance = Math.Ceiling(Math.Round(distance, 2) * 10) / 10;
            double fare=0;
            if(roundUpDistance <= 0.5)
            {
                fare = 2.4;
            }
            else if(roundUpDistance <= 9)
            {
                fare = 2.4 + (roundUpDistance - 0.5) * 0.4;
            }
            else if(roundUpDistance > 9)
            {
                fare = 2.4 + 85 * 0.04 + (roundUpDistance - 9) * 0.5;
            }
            else
            {
                Console.WriteLine("Please enter distance > 0");
            }
            Console.WriteLine(fare);
        }
    }
}

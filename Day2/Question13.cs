using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Question13
    {
        static void Main()
        {
            Console.WriteLine("Please enter your marks (0-100):");
            int mark = Int32.Parse(Console.ReadLine());
            if(mark<40)
            {
                Console.WriteLine("You scored {0} marks which is a F grade.", mark);
            }
            else if(mark<60)
            {
                Console.WriteLine("You scored {0} marks which is a C grade.", mark);
            }
            else if(mark<80)
            {
                Console.WriteLine("You scored {0} marks which is a B grade.", mark);
            }
            else if(mark<100)
            {
                Console.WriteLine("You scored {0} marks which is a A grade.", mark);
            }
            else
            {
                Console.WriteLine("**Error** Please reenter marks between 0 to 100.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Question12
    {
        static void Main()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your gender (M/F):");
            string gender = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            int age = Int32.Parse(Console.ReadLine());
            if (gender == "M")
            {
                if (age > 40)
                {
                    Console.WriteLine("Good Morning Uncle {0}", name);
                }
                Console.WriteLine("Good Morning Mr. {0}", name);
            }
            else if (gender == "F")
            {
                if (age > 40)
                {
                    Console.WriteLine("Good Morning Aunty {0}", name);
                }
                Console.WriteLine("Good Morning Ms. {0}", name);
            }
            else
            {
                Console.WriteLine("Invalid gender type. Please reenter your gender.");
            }
        }
    }
}

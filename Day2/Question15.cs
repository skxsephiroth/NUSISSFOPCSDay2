using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Question15
    {
        static void Main()
        {
            Console.WriteLine("Please enter a three digit integer (100-999):");
            int number = Int32.Parse(Console.ReadLine());
            int thirdDigit = number % 10;
            int secondDigit = ((number - thirdDigit) / 10) % 10;
            int firstDigit = (number - secondDigit * 10 - thirdDigit) / 100;
            int armStrong = firstDigit * firstDigit * firstDigit + secondDigit * secondDigit * secondDigit + thirdDigit * thirdDigit * thirdDigit;
            Console.WriteLine(number == armStrong);
        }
    }
}

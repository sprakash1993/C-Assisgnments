using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign2Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400 == 0) || ((year % 4) == 0 && (year % 400) != 0))
                Console.WriteLine("The given year is a leap year");
            else
                Console.WriteLine("This is not a leap year");

            Console.ReadKey();
        }
    }
}

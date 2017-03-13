using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignQ6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A can finish the work in 15 days and B in 20 days\n");

            double workDoneInADay = (1.0 / 15) + (1.0 / 20);
            double noOfDays = Math.Ceiling( 1 / workDoneInADay);
            Console.WriteLine("No of days required to complte the work simultaneously : {0} days", noOfDays);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of working hours");
            double noOfHours = Convert.ToDouble(Console.ReadLine());
            double hourlyRate = 12;
            double totalIncome = noOfHours * hourlyRate;
            double netIncome = totalIncome - 0.15 * totalIncome;
            Console.WriteLine("Net Income = $" + netIncome);


        }
    }
}

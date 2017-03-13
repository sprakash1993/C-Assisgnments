using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign2Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the deposit amount");
            double deposit = Convert.ToDouble(Console.ReadLine());
            double interest;
            if (deposit <= 1000)
            {
                interest = 0.04 * deposit;
            }
            else if (deposit <= 5000)
            {
                interest = 0.045* deposit;
            }
            else
            {
                interest = 0.05 * deposit;
            }
            Console.WriteLine("Interest = " + interest);
            Console.ReadKey();
        }
    }
}

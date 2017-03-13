using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign4Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Deposit amount : ");
            double deposit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the period of deposit (in years): ");
            double periodOfDeposit = Convert.ToDouble(Console.ReadLine());
            double interest,amount;
            amount = deposit;
            for (int i = 0; i < periodOfDeposit; i++)
            {
                interest = 0.04 * amount;
                amount = amount + interest;
            }
            Console.WriteLine("Maturity amount = " + amount);
            Console.ReadKey();

        }
    }
}

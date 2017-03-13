using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign2Q4
{
    class Program
    {
        public static double calculateTax(int income)
        {
            if (income <= 100000)
            {
                return 0;
            }
            else if (income <= 300000)
            {
                return 0.015 * income;
            }
            else
                return 0.028 * income;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter the gross pay");
            int grossPay = Convert.ToInt32(Console.ReadLine());
            double Tax = calculateTax(grossPay);
            Console.WriteLine("Tax pay : " + Tax);
            Console.ReadKey();

        }
    }
}

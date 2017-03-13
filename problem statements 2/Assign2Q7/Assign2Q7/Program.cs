using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign2Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Not a Prime Number");
                    flag = 1;
                    break;
                }

            }
            if(flag==0)
            Console.WriteLine("Prime number");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign3Q4
{
    class Program
    {
        public static bool isPrime(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("enter the limit:");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int j = 1; j <= num; j++)
            {
                if (isPrime(j))
                    count++;
            }
    
            Console.WriteLine("Count of Prime numbers: " + count);
            Console.ReadKey();

        }
    }
}

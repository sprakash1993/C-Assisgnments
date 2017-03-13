using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign3Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int num3 = 1;
            int num4=0;
            Console.WriteLine("Enter the value of n to generate nth Tribonocci number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 3;
            Console.Write("The Tribonocci sequence is : {0} {1} {2}", num1, num2,num3);
            while (count < n)
            {
                num4 = num1 + num2 + num3;
                Console.Write(" " + num4);
                num1 = num2;
                num2 = num3;
                num3 = num4;
                count++;
            }
            Console.WriteLine("\n\nnth Tribonocci number is : " + num4);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign3Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int num3;
            Console.WriteLine("Enter the count to generate fibonocci numbers : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 2;
            Console.Write("The fibonocci sequence is : {0} {1}",num1,num2);
            while (count < n)
            {
                num3 = num1 + num2;
                Console.Write(" " + num3);
                num1 = num2;
                num2 = num3;
                count++;
            }
            Console.ReadKey();

        }
    }
}

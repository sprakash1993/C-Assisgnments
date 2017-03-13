using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign2Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int max = Math.Max(a, b);
            Console.WriteLine("Max of two numbers: " + max);
            int min = Math.Min(a, b);
            Console.WriteLine("Min of two numbers: " + min);

            Console.ReadKey();

        }
    }
}

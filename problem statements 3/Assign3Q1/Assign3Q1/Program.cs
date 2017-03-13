using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign3Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit");
            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Even numbers within the limit are: ");
            for (int i = 1; i < num; i++)
            {
                if (i % 2 == 0)
                    Console.Write(" " + i + " ");
            }
            Console.ReadKey();

        }
    }
}

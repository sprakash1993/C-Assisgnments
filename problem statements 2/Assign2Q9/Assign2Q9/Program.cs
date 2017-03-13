using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign2Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Largest number : {0}", a);
                }
                else
                {
                    Console.WriteLine("Largest number : {0}", c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("Largest number : {0}", b);
                }
                else
                    Console.WriteLine("Largest number : {0}", c);
            }
            Console.ReadKey();
        }
    }
}

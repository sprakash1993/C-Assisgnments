using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign2Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Variable");
            char var = Convert.ToChar(Console.ReadLine());
            switch (var)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u': Console.WriteLine("The entered alphabet is vowel");
                           break;
                default: Console.WriteLine("The entered alphabet is not a vowel");
                           break;

            }

            Console.ReadKey();
        }
    }
}

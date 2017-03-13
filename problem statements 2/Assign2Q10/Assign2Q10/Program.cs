using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign2Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number is : " + number);
            int rem;
            int reverse =0;
            while(number!=0)
            {
                rem=number%10;
                number=number/10;
                reverse=reverse*10+rem;
            }
            Console.WriteLine("Reverse : " + reverse);
            Console.ReadKey();



        }
    }
}

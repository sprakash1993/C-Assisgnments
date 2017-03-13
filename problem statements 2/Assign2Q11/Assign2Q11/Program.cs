using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign2Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers");
            int num1 = Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());
            int num3 = Convert.ToInt16(Console.ReadLine());
            int result = 0;
            if ((num1 >= num2) && (num1 >= num3))
                result = num1;
            else if ((num2 >= num1) && (num2 >= num3))
                result = num2;
            else
                result = num3;
            Console.WriteLine("Max of three numbers is : " + result);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the area of Square:");
            
            double Area = Convert.ToDouble(Console.ReadLine());
            int Length = Convert.ToInt32(Math.Sqrt(Area));
            
            Console.WriteLine("\nPerimeter of Square : " + 4 * Length);


        }
    }
}

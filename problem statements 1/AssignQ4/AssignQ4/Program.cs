using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignQ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the accelration on rocket:");
            double acceleration = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time:");
            double time = Convert.ToDouble(Console.ReadLine());
            double speed = acceleration * time;
            double height = 1  * speed * time/2;        
            Console.WriteLine("\nHeight of rocket = " + height + " meters");
            Console.ReadKey();
        }
    }
}

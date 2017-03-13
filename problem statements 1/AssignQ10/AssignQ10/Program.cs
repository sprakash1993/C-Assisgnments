using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignQ10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of sphere");
            double radius = Convert.ToDouble(Console.ReadLine());

            double volumeOfSphere = 4 * Math.PI * radius * radius;

            double lengthOfCube = Math.Pow(volumeOfSphere,(1.0/3));
            Console.WriteLine("Length of side of cube :  " + lengthOfCube);
            Console.ReadKey();
        }
    }
}

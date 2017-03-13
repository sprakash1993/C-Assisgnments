using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignQ9
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalDistance = 150.0;

            int timeTaken = (10 * 60 + 54) - (8 * 60 + 24);

            double averageSpeed = totalDistance / timeTaken;
            Console.WriteLine("Average Speed = " + averageSpeed);
            Console.ReadKey();


        }
    }
}

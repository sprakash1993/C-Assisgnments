using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignQ5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length and breadth of rectangular floor");
            double length, breadth;
            length = Convert.ToDouble(Console.ReadLine());
            breadth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of square tile");
            double edgeLength = Convert.ToDouble(Console.ReadLine());
            double areaOfFloor = length * breadth;
            double areaOfTile = edgeLength * edgeLength;

            double noOfTiles = Math.Ceiling(areaOfFloor / areaOfTile);
            Console.WriteLine("Number of tiles required = {0}", noOfTiles); 
            Console.ReadKey();
        
        }
    }
}

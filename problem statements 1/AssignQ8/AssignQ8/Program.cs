using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignQ8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Volume of cube : 27 cubic meters");
            int volume = 27;
            int side = Convert.ToInt32(Math.Pow(volume,(1.0/3)));
            double NewVolume = Math.Pow(2*side,3);

            Console.WriteLine("New Volume = {0}", NewVolume);
            Console.WriteLine("Difference in  Volume = {0}", (NewVolume - 27));
            Console.ReadKey();

        }
    }
}

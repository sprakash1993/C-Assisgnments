using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignQ11
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTimeTaken = 60 + 24;

            double distanceTravelled = totalTimeTaken / 6 * 30 ;
            Console.WriteLine("distance travelled : " + distanceTravelled);
            Console.ReadKey();
        }
    }
}

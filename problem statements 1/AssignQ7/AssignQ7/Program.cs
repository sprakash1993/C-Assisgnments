using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignQ7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Commission from Brian's painting : $240,000\n\nCommission from Chad's painting : $300,000\n\n");
            double salesOfBrian = 240000 / 0.8;
            double salesOfClad = 300000 / 0.85;
            double TotalEarnings = (0.2 * salesOfBrian) + (0.15 * salesOfClad);
            Console.WriteLine("Total earnings = {0}", TotalEarnings);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of attendees"); 
            int noOfAttendees = Convert.ToInt32(Console.ReadLine());
            int costPerTicket = 5;
            int performanceCost = 20;

            double income = noOfAttendees * costPerTicket - performanceCost - 0.50 * noOfAttendees;

            Console.WriteLine("\nIncome = $" + income); 


        }
    }
}

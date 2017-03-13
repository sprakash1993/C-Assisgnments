using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assign2Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());
            char grade=' ';
            if (marks >= 80 && marks < 100)
                grade = 'A';
            else if (marks >= 65 && marks < 80)
                grade = 'B';
            else if (marks >= 45 && marks < 65)
                grade = 'C';
            else if (marks < 45)
                grade = 'D';
            else
                Console.WriteLine("enter a proper value for marks");

        
            if(grade!=' ') 
            Console.WriteLine("Grade is :" + grade);
            Console.ReadKey();

            

        }
    }
}

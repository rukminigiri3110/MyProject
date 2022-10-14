using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class YearsDays
    {
        static void Main(String[]args)
        {
            int Days,Years,Weeks;
            int DaysInWeek = 7;
            Console.WriteLine("Enter the Number of Days=");
            Days = int.Parse(Console.ReadLine());
            Years = Days / 365;
            Weeks = (Days % 365) / DaysInWeek;
            Days = (Days % 365) % 7;
            Console.WriteLine("Year=" + Years);
            Console.WriteLine("Week=" + Weeks);
            Console.WriteLine("Days=" + Days);
           
        }
    }
}

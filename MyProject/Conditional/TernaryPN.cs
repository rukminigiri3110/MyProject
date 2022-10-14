using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional
{
    class TernaryPN
    {
        static void Main(String[]args)
        {
            int n;
            Console.WriteLine("Enter a Number =");
            n = int.Parse(Console.ReadLine());
            String str = (n== 0) ? "Zero": n>0 ? "Positive" : "Negative";

            Console.WriteLine(n + "is" + str);
            Console.ReadLine();

        }
    }
}

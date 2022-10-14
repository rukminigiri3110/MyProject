using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Percentage
    {
        static void Main(String[]args)
        {
            double English, Phy, Chem, Maths,Comp, Total;
            double Percentage,Average;
            English = 65;
            Phy = 60;
            Chem = 60;
            Maths = 70;
            Comp = 77;
            Console.WriteLine("Marks of English=" + English);
            Console.WriteLine("Marks of Physics=" + Phy);
            Console.WriteLine("Marks of Chemistry=" + Chem);
            Console.WriteLine("Marks of Mathmatics=" + Maths);
            Console.WriteLine("Marks of Computer=" + Comp);

            Total = English + Phy + Chem + Maths + Comp;
            Average = Total / 5.0;
            Percentage = (Total / 500.0) * 100;

            Console.WriteLine("Total Marks =" + Total);
            Console.WriteLine("Average Marks=" + Average);
            Console.WriteLine("Percentage=" + Percentage);

        }
    }
}

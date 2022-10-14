using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional
{
    class Percentage
    {
        static void Main(string[]args)
        {
            double English, Phy, Chem, Maths, Comp, Total;
            double Percentage, Average;
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

            if(Percentage>70)
            {
                Console.WriteLine("Result is Distinction");
            }
            else if(Percentage>60 && Percentage<70)
            {
                Console.WriteLine("Result is First Class");
            }
            else if(Percentage>50 && Percentage<60)
            {
                Console.WriteLine("Result is Second Class");
            }
            else if(Percentage>35 && Percentage<45)
            {
                Console.WriteLine("Result is Fail");
            }
        }
    }
}

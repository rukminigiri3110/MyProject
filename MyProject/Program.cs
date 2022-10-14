using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Age");
            int age = int.Parse(Console.ReadLine());
            if(age>=13 && age <= 19)
            {
                Console.WriteLine("Person is Teenage");
            }
            else
            {
                Console.WriteLine("Person is not Teenage");
            }
        }
    }


    class Average
    {
        static void Main(String[] args)
        {
            int sum=0;
            float Average;
            Console.WriteLine("Enter a Numbers");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i < 5; i++)
            {
                sum = sum + num;
            }
            Average = sum / 5;
            Console.WriteLine("Average of num is" + Average);
        }
    }

    class Number
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a Number=");
            int n = int.Parse(Console.ReadLine());
            int basenumber = 1;
            int exponent = 0;
            int original = n;
            while (n > 0)
            {
                int rem = n % 10;
                basenumber = rem;
                n = n / 10;
                exponent++;

            }
            Console.WriteLine(exponent);
            int  power = 1;
            
            for (int i = 1; i <= exponent; i++)
                power = power * basenumber;


        }
    }

    class Automorphic
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a Number=");
            int num = int.Parse(Console.ReadLine());
            int square = 1;
            int count = 0;
            int temp=num;
            
            while (num> 0)
            {
                int digit = num % 10;
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);

            num = temp;
            int Power = 1;
            int Base = 10;
            square = num * num;

            for(int i=1;i<=count;i++)
            {
                Power = Power * Base;
            }
            Console.WriteLine(square);
            int last = square % Power;
            if (num == last)

            {
                Console.WriteLine("Automorphic:");
            }
            else
            {
                Console.WriteLine(" Not a Automorphic:");
            }
            }
        }
  

    class N
    {
        static void Main(String[] args)
        {
            int row, column;
            for (row = 0; row <= 5; row++)
            {
                for (column = 0; column <= 5; column++)
                {
                    if (column == 1 || column == 4 || (row == column && column != 0 && column != 5))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    class Kaparkar
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a Number=");
            int num = int.Parse(Console.ReadLine());
            int digit = 0;
            int square = 0;

            while (num > 0)
            {
                num =num/ 10;
                digit++;
            }
            Console.WriteLine(digit);
            square = num * num;
            int power=1;
            for(int count = 1; count < digit; count++)
            {
              //  int fact = power(10, count);/
            } 
        }
    }
  
    class Plus
    {
        static void Main(String[] args)
        {
            for(int i = 1; i <=5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    if(i==3 || j==3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }

    
}

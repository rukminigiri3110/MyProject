using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class Program
    {
        static void Main(String[] args)
        {
            int sum = 0;
            for (int i = 21; i <= 35; i++)
            {
                if (i % 2== 1)
                {  
                    
                    Console.WriteLine(i);
                   
                }
            }
 
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Age");
            int age = int.Parse(Console.ReadLine());
            if (age >= 13 && age <= 19)
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
            int sum = 0;
            float Average;
            Console.WriteLine("Enter a Numbers");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                sum = sum + num;
            }
            Average = sum / 5;
            Console.WriteLine("Average of num is" + Average);
        }
    }

    class Number1
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
            int power = 1;

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
            int temp = num;

            while (num > 0)
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

            for (int i = 1; i <= count; i++)
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
                num = num / 10;
                digit++;
            }
            Console.WriteLine(digit);
            square = num * num;
            int power = 1;
            for (int count = 1; count < digit; count++)
            {
                //  int fact = power(10, count);/
            }
        }
    }

    class Plus
    {
        static void Main(String[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 3 || j == 3)
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

   class Program2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a Number=");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int sum=0;
            for(int i = 20; i <= 35; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    count++;
                    sum = sum + i;
                }
                
            }
            int Average = sum / count;
            Console.WriteLine("Average is =" + Average);
        }
    }

    class series
    {
        static void Main(String[] args)
        {
            int N = 10;
            int T;
            for (int i = 1; i <= N; i++)
            {
                T = i * i * i - 1;
                Console.WriteLine(T);
                
            }
        }
    }
     
   /* class series2
    {
        static void Main(String[] args)
        {
            int N = 10;
            int p = 2;
            int T;
            for (int i = 1; i <= N; i++)
            {
                T = i*p+1;
                
                Console.WriteLine(A);

            }
        }
    }*/

    class Duck
    {
        static void Main(String[] args)
        {
            int dno, dkno=0, count;
            count = 0;
            Console.WriteLine("Check whether a number is a Duck Number or not:");
            int num = int.Parse(Console.ReadLine());
            dno = dkno;
            while (dkno > 0)
            {
                if (dkno % 10 == 0)
                {
                    count = 1;
                    break;
                }
                dkno /= 10;
            }
            if (dno > 0 && count == 1)
            {
                Console.WriteLine(" The given number is a Duck Number.");
            }
            else
            {
                Console.WriteLine(" The given number is not a Duck Number.");
            }

        }
    }

    class oneseries
    {
        static void Main(String[] args)
        {
            int s = 0;
            for(int i = 0; i <= 7; i++)
            {
                s = s * 10+1;
                int n = s + 10;
                Console.Write(" ");
                Console.Write(s);
            }
            Console.Write("");
        }
    }

    class Fibonacciseries
    {
        static void Main(String[] args)
        {
            int f = 0,f1=1,f2=0,n=10;
            Console.WriteLine("Enter the terms of series=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonaccie Series=");
            for(int i = 0; i <= n; i++)
            {
                f = f1 + f2;
                f1 = f2;
                f2 = f;
                Console.WriteLine(f + " ");
            }
        }
    }

    class DisplayColor
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a Number=");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                if (n >= 2 && n <= 8)
                {
                    Console.WriteLine("Green");
                }
                else
                {
                    Console.WriteLine("Red");
                }
            }
            else
            {
                if (n > 8)
                {
                    Console.WriteLine("White");
                }
                else
                {
                    Console.WriteLine("Black");
                }
            }
        }
    }

    class Pattern
    {
        static void Main(String[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                if (i % 2 == 0)
                {
                    char ch = 'A';
                    for(int j = 1; j <= i; j++)
                    {
                        Console.Write(ch);
                        ch++;
                    }
                }
                else
                {
                    for(int k = 1; k <= i; k++)
                    {
                        Console.Write(k);
                    }
                }
                Console.WriteLine();
            }
        }
    }

    class PrimeAverage
    {
        static void Main(String[] args)
        {
            int sum = 0,flag= 0;
            for(int i = 2; i <= 10; i++)
            {
                int count = 0;
                for(int j = 2; j <= 10; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    flag++;
                }
            }
            int Average = sum / flag;
            Console.WriteLine("Average=" + Average);
        }
    }
}

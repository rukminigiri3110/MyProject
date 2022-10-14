using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class TestPaer2
    {
        static void Main(String[] args)
        {
            long sum = 0, fact = 1;
            Console.WriteLine("Enter a Factorial series=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
                sum = sum + fact;
            }
            Console.WriteLine("Factorial=" + sum);
        }
    }

    class fibbonaciseries
    {
        static void Main(String[] args)
        {
            int f = 0, f1 = 1, f2=0,n;
            Console.WriteLine("Enter terms of Fibonacci Series=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("fibonacci Series =");
            for(int i = 1; i <= 20; i++)
            {
                f = f1 + f2;
                Console.WriteLine(" " + f);
                f1 = f2;
                f2 = f;
            }

        }
    }

    class value
    {
        static void Main(String[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
                Console.WriteLine(i);
            }
        }
    }

    class evenodd
    {
        static void Main(String[] args)
        {
            int square;
            for(int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                if (i % 2 != 0)
                {
                    square = -i * i;
                    Console.WriteLine(-i + "=" + square);
                }
            }
        }
    }

   class loop
    {
        static void Main(String[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);
        }
    }

   class series
    {
        static void Main(String[] args)
        {
            
            for(int i = 1; i <= 10; i++)
            {
                int series= (i * i) + (i * i * i);
                Console.Write(series+" ");
            }
        }
    }

    class divisibleno
    {
        static void Main(String[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if ((i % 5 != 0) || (i % 10 != 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Loop
    {
        static void main(String[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            int i = 1; 
            int k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k ="+k +"i ="+i);

        }
    }

    class spy
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Number=");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int mul = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                mul = mul * digit;
                num = num / 10;
            }
            Console.WriteLine(sum + " " + mul);
            if (sum == mul)
            {
                Console.WriteLine("Spy Number:");
            }
            else
            {
                Console.WriteLine(" Not a Spy Number:");
            }
        }
    }

    class Program2
    {
        static void Main(String[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }
        }
    }

}

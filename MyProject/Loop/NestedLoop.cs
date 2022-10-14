using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class NestedLoop
    {
        static void Main(String[]args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class star
    {
        static void Main(String[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class star2
    {
        static void Main(String[]args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class NoPattern
    {
        static void Main(String[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }

    class NoPattern1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }

    class NoPattern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class star3
    {
        static void Main(String[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int k = 4; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class star4
    {
        static void Main(String[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 4; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }

    class AlbhabetPattern
    {
        static void Main(String[] args)
        {
           for(char i = 'A'; i <= 'D'; i++)
            {
               for(char j='A';j<'D';j++)
                {
                    Console.Write(i);
                }
            }
            Console.WriteLine();
        }
    }

    class num
    {
        static void Main(String[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }

    
}

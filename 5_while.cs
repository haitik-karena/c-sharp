using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Any Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1, old = 2, New = 3;
            while(i <= n)

            {
                if (i <= 3)
                {
                    Console.Write(i + "  ");
                    i++;
                }
                else
                {
                    i = old * New;
                    if (i >= n)
                    {
                        break;
                    }
                    Console.Write(i + "  ");
                    old = New;
                    New = i;

                }

            }
            Console.Read();

        }
    }
}

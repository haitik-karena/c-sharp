using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 for White/Black");
            Console.WriteLine("2 for Black/Green ");
            Console.WriteLine("3 for Yellow/Red");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;

                case 2:

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;
                case 3:

                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    break;

                default:
                    Console.Write("Select 1 2 3 ");
                    break;
            }

            switch (n)
            {
                case 1:

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;

                case 2:

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;
                case 3:

                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    break;

                default:
                    Console.Write("Select 1 2 3 ");
                    break;

            }
            Console.Read();
        }
    }
}

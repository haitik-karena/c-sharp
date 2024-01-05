using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear(); ;
            int n1, n2, n3, sum;
            Console.Write("enter num :");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter num ;");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter num ;");
            n3 = Convert.ToInt32(Console.ReadLine());

            sum = n1 + n2 - n3 ;
            Console.Write("sum is = " + sum);
            Console.Read();


        }
    }
}

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
            int a,b,c,d, sum1,sum2,sum3,sum4,sum5,sum6,sum7;
            Console.Write("enter num :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter num ;");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter num ;");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter num ;");
            d = Convert.ToInt32(Console.ReadLine());

            sum1 = a + b - c;
            sum2 = a + b * (d - c) / a + c;
            sum3 = a / b + c * (a * b);
            sum4 = a - b - c;
            sum5 = a * b / c;
            sum6 = c / a + (d - c) * a;
            sum7 = a + b + (c + a / b);

            Console.WriteLine("sum is = " + sum1);
            Console.WriteLine("sum is = " + sum2);
            Console.WriteLine("sum is = " + sum3);
            Console.WriteLine("sum is = " + sum4);
            Console.WriteLine("sum is = " + sum5);
            Console.WriteLine("sum is = " + sum6);
            Console.WriteLine("sum is = " + sum7);
            {
            }
            Console.Read();


        }
    }
}

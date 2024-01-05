using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,i ;

            Console.Write("enter num :");
         //   n1 = Convert.ToInt32(Console.ReadLine());
            i = Convert.ToInt32(Console.ReadLine());

            {
                for ( n1 = 0; n1<=i; n1++)
                {
                    Console.WriteLine(n1);
                }

            }
            Console.Read();
        }
    }
}

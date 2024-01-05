using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("enter any num : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int old = 2, New = 3;
            for(int i = 1; i <= n;  i++)

            {
                if (i <= 3)
                {
                    Console.Write(i + " ");
                }
                else
                { 
                    i = old*New;
                    if(i >= n)
                    {
                        break;
                    }
                    Console.Write(i+ " ");
                    old = New;
                    New = i;
                }
            }
            Console.Read();
        }
    }
}

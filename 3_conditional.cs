using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.Write("enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 0)
            {
                if (age >= 18 && age<60)
                {
                    Console.Write("adult");
                }
                else if (age < 18)
                {
                    Console.Write("teen");
                }
                else if (age >60)
                {
                    Console.Write("senior citizen");
                }
                
            } 
       
            Console.Read();
        }
    }
}

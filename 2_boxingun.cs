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
           int i=10;
            object obj = i; //boxing
            Console.WriteLine(obj);
            int j = (int)obj; //unboxing
            Console.Write(j);
            Console.Read();
        }
    }
}

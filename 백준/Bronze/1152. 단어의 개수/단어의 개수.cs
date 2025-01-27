using System;
using System.Collections.Generic;
using System.Linq;

namespace Test241229
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().Trim();
            if(str.Equals(""))
            {
                Console.WriteLine("0");
                return;
            }
            string[] strings = str.Split();
            Console.WriteLine(strings.Length);
        }
    }
}

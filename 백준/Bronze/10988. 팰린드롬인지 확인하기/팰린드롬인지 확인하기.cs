using System;
using System.Collections.Generic;
using System.Linq;

namespace Test241229
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp = Console.ReadLine();
            char[] a = temp.ToCharArray();
            
            a = a.Reverse().ToArray();
            string check = new string(a);

            if(temp.Equals(check))
            {
                Console.WriteLine("1");
            } else
            {
                Console.WriteLine("0");
            }
        }
    }
}

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
            int num = int.Parse(Console.ReadLine());

            char[] arr = temp.ToCharArray();

            Console.WriteLine(arr[num-1]);
            
        }
    }
}

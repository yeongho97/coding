using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;

namespace Test241229
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int A = int.Parse(temp[0]);
            int B = int.Parse(temp[1]);
            int V = int.Parse(temp[2]);

            double result = 0.0;

            result = Math.Ceiling((double)(V - B) / (A - B));

            Console.WriteLine(result);
        }
    }
}

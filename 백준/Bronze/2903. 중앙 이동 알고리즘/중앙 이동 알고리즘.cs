using System;
using System.CodeDom.Compiler;
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
            int N = int.Parse(Console.ReadLine()); // 2
            int result = 1 + (int)Math.Pow(2, N);
            Console.WriteLine(Math.Pow(result, 2));
        }
    }
}

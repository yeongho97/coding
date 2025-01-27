using System;
using System.Collections.Generic;
using System.Linq;

namespace Test241229
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            char[] chars = Console.ReadLine().ToCharArray();

            int sum = chars.Select(c => int.Parse(c.ToString())).Sum();

            Console.WriteLine(sum);
        }
    }
}

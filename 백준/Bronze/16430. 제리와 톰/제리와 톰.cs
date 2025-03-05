using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            string temp = Console.ReadLine();
            int A = int.Parse(temp.Split()[0]);
            int B = int.Parse(temp.Split()[1]);

            Console.WriteLine($"{B-A} {B}");
        }
    }
}

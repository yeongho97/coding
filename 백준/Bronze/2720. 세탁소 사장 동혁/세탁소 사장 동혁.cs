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
            int countQ, countD, countN, countP = 0;
            int Quarter = 25;
            int Dime = 10;
            int Nickel = 5;
            int Penny = 1;

            int T = int.Parse(Console.ReadLine());
            int[] TestCase = new int[T];

            for(int i = 0; i<T; i++)
            {
                TestCase[i] = int.Parse(Console.ReadLine());
            }

            foreach(int i in TestCase)
            {
                int temp = i;
                countQ = temp / Quarter; // 몫
                temp = temp % Quarter;

                countD = temp / Dime; // 몫
                temp = temp % Dime;

                countN = temp / Nickel; // 몫
                temp = temp % Nickel;

                countP = temp / Penny; // 몫
                temp = temp % Penny;

                Console.WriteLine($"{countQ} {countD} {countN} {countP}");
            }
        }
    }
}

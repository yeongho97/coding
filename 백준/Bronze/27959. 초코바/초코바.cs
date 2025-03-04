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
            int N = int.Parse(temp.Split()[0]);
            int M = int.Parse(temp.Split()[1]);

            if(100*N >= M)
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }
        }
    }
}

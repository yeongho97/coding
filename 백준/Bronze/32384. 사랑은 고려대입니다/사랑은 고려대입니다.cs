using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string temp = "LoveisKoreaUniversity";
            string result = "";
            
            for(int i = 0; i<N; i++)
            {
                result += $"{temp} ";
            }

            Console.WriteLine(result);


        }
    }
}

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
            int N = int.Parse(temp.Split()[0]);
            int M = int.Parse(temp.Split()[1]);

            int[] list = new int[N];

            for(int i = 0; i<N; i++)
            {
                list[i] = i + 1;
            }

            for(int j = 0; j<M; j++)
            {
                string num = Console.ReadLine();
                int I = int.Parse(num.Split()[0]); // 1 3 1 2 // 0 2 0 1
                int J = int.Parse(num.Split()[1]); // 2 4 4 2 // 1 3 3 1

                Array.Reverse(list, I-1, J-I+1);
            }

            foreach(int i in list)
            {
                Console.Write($"{i} ");
            }
        }
    }
}

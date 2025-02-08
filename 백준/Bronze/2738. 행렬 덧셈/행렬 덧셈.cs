using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp = Console.ReadLine();
            int N = int.Parse(temp.Split()[0]);
            int M = int.Parse(temp.Split()[1]);

            int[,] A = new int[N, M];
            int[,] B = new int[N, M];
            int[,] result = new int[N, M];

            for(int i = 0; i<N; i++)
            {
                temp = Console.ReadLine();
                for(int j = 0; j<M; j++)
                {
                    A[i,j] = int.Parse(temp.Split()[j]);
                }
            }

            for (int i = 0; i < N; i++)
            {
                temp = Console.ReadLine();
                for (int j = 0; j < M; j++)
                {
                    B[i, j] = int.Parse(temp.Split()[j]);
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    result[i, j] = A[i,j] + B[i,j];
                }
            }

            for(int i = 0; i<N; i++)
            {
                for(int j = 0; j<M; j++)
                {
                    Console.Write($"{result[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

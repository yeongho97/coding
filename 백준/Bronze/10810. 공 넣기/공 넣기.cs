using System;
using System.Collections.Generic; //HashSet을 사용하기 위해 필요
using System.Linq; //Linq를 사용하기 위해 필요
using System.Text; // StringBuilder를 사용하기 위해 필요

namespace Test241229
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            var temp = Console.ReadLine().Split();
            int arraycount = int.Parse(temp[0]);
            int count = int.Parse(temp[1]);

            int[] result = new int[arraycount];
            for (int i = 0; i < arraycount; i++)
            {
                result[i] = 0;
            } // 0 0 0 0 0

            for(int i = 0; i<count; i++)
            {
                var cmd = Console.ReadLine().Split();
                int I = int.Parse(cmd[0]); // 1
                int J = int.Parse(cmd[1]); // 2
                int K = int.Parse(cmd[2]); // 3

                for(int j = I-1; j<=J-1; j++)
                {
                    result[j] = K;
                }
            }

            sb.AppendLine(string.Join(" ", result));
            Console.WriteLine(sb.ToString());

        }
    }
}
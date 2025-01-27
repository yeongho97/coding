using System;

namespace Test241229
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()); // 2

            for(int i = 0; i < num; i++)
            {
                string result = null;

                string temp = Console.ReadLine(); // 3 ABC
                int T = int.Parse(temp.Split()[0]); // 3
                string S = temp.Split()[1]; // ABC

                char[] arr = S.ToCharArray();

                for(int j = 0; j<S.Length; j++) // A B C 올라가는거
                {
                    for(int k = 0; k<T; k++)
                    {
                        result += arr[j];
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}

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

            for(int i = 0; i<num; i++)
            {
                string temp = Console.ReadLine();
                int length = temp.Length;
                char[] chars = temp.ToCharArray();

                Console.WriteLine($"{chars[0]}{chars[length-1]}");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Test241229
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for(int i = 1; i<=30; i++)
            {
                list.Add(i);
            }

            for(int i = 0; i<28; i++)
            {
                var num = int.Parse(Console.ReadLine());
                list.Remove(num);
            }

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}

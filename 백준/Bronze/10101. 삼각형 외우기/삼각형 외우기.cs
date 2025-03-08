using System;
using System.Collections.Generic;
using System.Linq;

namespace Test241229
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();

            for(int i = 0; i<3; i++)
            {
                ints.Add(int.Parse(Console.ReadLine()));
            }

            if (ints.Sum() != 180)
            {
                Console.WriteLine("Error");
            } else
            {
                int var = ints.Where(x => x == 60).Count();
                if (var == 3)
                {
                    Console.WriteLine("Equilateral");
                }
                else
                {
                    if (ints[0] != ints[1] && ints[0] != ints[2] && ints[1] != ints[2])
                    {
                        Console.WriteLine("Scalene");
                    }
                    else
                    {
                        Console.WriteLine("Isosceles");
                    }
                }
            }
        }
    }
}

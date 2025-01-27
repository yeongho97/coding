using System;
using System.Collections.Generic;
using System.Linq;

namespace Test241229
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            for (char c = 'a'; c <= 'z'; c++)
            {
                keyValuePairs[c] = -1;
            }

            string str = Console.ReadLine().Trim();
            char[] chars = str.ToCharArray();

            for(int i = 0; i<str.Length; i++)
            {
                if (keyValuePairs[chars[i]] != -1)
                {
                    continue;
                }
                keyValuePairs[chars[i]] = i;
            }

            foreach (var pair in keyValuePairs)
            {
                Console.Write($"{pair.Value} ");
            }
        }
    }
}

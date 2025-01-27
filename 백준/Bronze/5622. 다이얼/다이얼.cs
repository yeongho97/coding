using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace Test241229
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            keyValuePairs.Add('A', 2);
            keyValuePairs.Add('B', 2);
            keyValuePairs.Add('C', 2);
            keyValuePairs.Add('D', 3);
            keyValuePairs.Add('E', 3);
            keyValuePairs.Add('F', 3);
            keyValuePairs.Add('G', 4);
            keyValuePairs.Add('H', 4);
            keyValuePairs.Add('I', 4);
            keyValuePairs.Add('J', 5);
            keyValuePairs.Add('K', 5);
            keyValuePairs.Add('L', 5);
            keyValuePairs.Add('M', 6);
            keyValuePairs.Add('N', 6);
            keyValuePairs.Add('O', 6);
            keyValuePairs.Add('P', 7);
            keyValuePairs.Add('Q', 7);
            keyValuePairs.Add('R', 7);
            keyValuePairs.Add('S', 7);
            keyValuePairs.Add('T', 8);
            keyValuePairs.Add('U', 8);
            keyValuePairs.Add('V', 8);
            keyValuePairs.Add('W', 9);
            keyValuePairs.Add('X', 9);
            keyValuePairs.Add('Y', 9);
            keyValuePairs.Add('Z', 9);

            string temp = Console.ReadLine();
            if(temp == null)
            {
                return;
            }
            char[] chars = temp.ToCharArray();

            foreach (char c in chars)
            {
                result += keyValuePairs[c]+1;
            }

            Console.WriteLine(result);
        }
    }
}

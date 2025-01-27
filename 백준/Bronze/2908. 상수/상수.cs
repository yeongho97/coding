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
            string A = temp.Split()[0];
            string B = temp.Split()[1];

            char[] achar = A.ToCharArray();
            char[] bchar = B.ToCharArray();

            achar = achar.Reverse().ToArray();
            bchar = bchar.Reverse().ToArray();

            string astr = new string(achar);
            string bstr = new string(bchar);

            if(int.Parse(astr.ToString())>int.Parse(bstr.ToString()))
            {
                Console.WriteLine(astr);
            } else
            {
                Console.WriteLine(bstr);
            }
        }
    }
}

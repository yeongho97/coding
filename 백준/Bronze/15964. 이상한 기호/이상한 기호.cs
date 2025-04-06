using System;

namespace Baekjoon
{

    public class Calculate
    {
        public int value(int a, int b)
        {
            return ((a + b) * (a - b));
        }
        
    }
    public class Program
    {
        static void Main(string[] args) // 맴버함수
        {
            Calculate calc = new Calculate();
            string[] temp = Console.ReadLine().Split();
            int a = int.Parse(temp[0]);
            int b = int.Parse(temp[1]);
            Console.WriteLine(calc.value(a, b));
        }
    }
}

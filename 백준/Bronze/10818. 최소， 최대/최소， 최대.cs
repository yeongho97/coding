int number = int.Parse(Console.ReadLine()); // 5

string temp = Console.ReadLine();
int[] numbers = temp.Split(' ').Select(int.Parse).ToArray();

Console.WriteLine($"{numbers.Min()} {numbers.Max()}");
string temp = Console.ReadLine();
int count = int.Parse(temp.Split(' ')[0]);
int check = int.Parse(temp.Split(' ')[1]);

int[] numbers = Console.ReadLine().Split(' ').Where(x => int.Parse(x) < check).Select(x => int.Parse(x)).ToArray();

Console.WriteLine(string.Join(" ", numbers));
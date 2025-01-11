int num = int.Parse(Console.ReadLine());
string[] temp = Console.ReadLine().Split(' ');
int check = int.Parse(Console.ReadLine());

int[] numbers = new int[num];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(temp[i]);
}

int count = numbers.Where(x => x == check).Count();

Console.WriteLine(count);
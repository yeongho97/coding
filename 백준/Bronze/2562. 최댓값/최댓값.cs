int[] numbers = new int[9];

for (int i = 0; i < 9; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

numbers.ToArray();

int max = numbers.Max();
int count = 0;

for (int i = 0; i < 9; i++)
{
    if (numbers[i] == max)
    {
        count = i+1;
    }
}

Console.WriteLine(max);
Console.WriteLine(count);
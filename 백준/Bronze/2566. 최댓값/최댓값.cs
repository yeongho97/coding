int max = 0;
int a = 0;
int b = 0;
int[,] numbers = new int[9,9];
for (int i = 0; i < 9; i++)
{
    string temp = Console.ReadLine();
    for (int j = 0; j < 9; j++)
    {
        numbers[i, j] = int.Parse(temp.Split()[j]);
    }
}

foreach (var item in numbers)
{
    if (item > max)
    {
        max = item;
    }
}

for(int i = 0; i<9; i++)
{
    for (int j = 0;j < 9; j++)
    {
        if (numbers[i,j] == max)
        {
            a = i;
            b = j;
        }
    }
}

Console.WriteLine(max);
Console.WriteLine($"{a+1} {b+1}");
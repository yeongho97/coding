string temp = Console.ReadLine();
int arraycount = int.Parse(temp.Split(' ')[0]);
int count = int.Parse(temp.Split(' ')[1]);

int[] result = new int[arraycount];
for (int i = 0; i < arraycount; i++)
{
    result[i] = i + 1;
} // 1 2 3 4 5

for(int i = 0; i<count; i++)
{
    temp = Console.ReadLine();
    int a = int.Parse(temp.Split(' ')[0]);
    int b = int.Parse(temp.Split(' ')[1]);

    int sawp = result[a - 1];
    result[a-1] = result[b-1];
    result[b-1] = sawp;
}

Console.WriteLine(string.Join(" ", result));
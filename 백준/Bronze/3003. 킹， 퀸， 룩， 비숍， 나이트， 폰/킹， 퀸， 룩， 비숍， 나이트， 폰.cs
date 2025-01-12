Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
keyValuePairs.Add(0, 1);
keyValuePairs.Add(1, 1);
keyValuePairs.Add(2, 2);
keyValuePairs.Add(3, 2);
keyValuePairs.Add(4, 2);
keyValuePairs.Add(5, 8);

int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x.ToString())).ToArray();
int[] result = new int[numbers.Length];

for(int i = 0; i<numbers.Length; i++)
{
    result[i] = keyValuePairs[i]-numbers[i];
}

Console.WriteLine (string.Join(" ", result));
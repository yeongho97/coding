Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();
keyValuePairs.Add("A+", 4.5);
keyValuePairs.Add("A0", 4.0);
keyValuePairs.Add("B+", 3.5);
keyValuePairs.Add("B0", 3.0);
keyValuePairs.Add("C+", 2.5);
keyValuePairs.Add("C0", 2.0);
keyValuePairs.Add("D+", 1.5);
keyValuePairs.Add("D0", 1.0);
keyValuePairs.Add("F", 0.0);

double[] numbers = new double[20];
string[] temp = new string[20];
var sum = 0.0;
double check = 0.0;

for(int i = 0; i<20; i++)
{
    string str = Console.ReadLine();
    numbers[i] = double.Parse(str.Split(' ')[1]);
    temp[i] = str.Split(' ')[2];
}

for (int j = 0; j<20; j++)
{
    if (temp[j] == "P")
    {
        continue;
    }
    check += numbers[j];
    sum += numbers[j] * keyValuePairs[temp[j]];
}

Console.WriteLine(sum / check);
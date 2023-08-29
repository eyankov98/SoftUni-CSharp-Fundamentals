int repeatTimes = int.Parse(Console.ReadLine()) * 2;

int sum = 0;

for (int i = 1; i <= repeatTimes; i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
        sum += i;
    }
}

Console.WriteLine($"Sum: {sum}");
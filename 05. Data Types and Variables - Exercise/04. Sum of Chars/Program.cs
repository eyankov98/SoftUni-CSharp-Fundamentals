int n = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 0; i < n; i++)
{
    char charr = char.Parse(Console.ReadLine());

    sum = sum + charr;
}

Console.WriteLine($"The sum equals: {sum}");
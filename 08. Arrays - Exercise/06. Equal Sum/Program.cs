int[] inputNumbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

if (inputNumbers.Length == 1)
{
    Console.WriteLine(0);
    return;
}

for (int i = 0; i < inputNumbers.Length; i++)
{
    int leftSum = 0;
    int rightSum = 0;

    for (int j = 0; j < i; j++)
    {
        leftSum = leftSum + inputNumbers[j];
    }

    for (int k = i + 1; k < inputNumbers.Length; k++)
    {
        rightSum = rightSum + inputNumbers[k];
    }

    if (leftSum == rightSum)
    {
        Console.WriteLine($"{i}");
        return;
    }
}

Console.WriteLine("no");
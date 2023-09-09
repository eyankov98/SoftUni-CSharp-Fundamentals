int[] inputNumbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < inputNumbers.Length; i++)
{
    int topInteger = inputNumbers[i];

    bool isTopInteger = true;

    for (int j = i + 1; j < inputNumbers.Length; j++)
    {
        if (topInteger <= inputNumbers[j])
        {
            isTopInteger = false;
            break;
        }
    }
    if (isTopInteger)
    {
        Console.Write(topInteger + " ");
    }
}
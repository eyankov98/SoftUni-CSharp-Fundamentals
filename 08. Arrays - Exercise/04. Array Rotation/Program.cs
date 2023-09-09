int[] inputNumbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int rotation = int.Parse(Console.ReadLine());

for (int i = 0; i < rotation; i++)
{
    int firstNumber = inputNumbers[0];

    for (int j = 0; j < inputNumbers.Length - 1; j++)
    {
        inputNumbers[j] = inputNumbers[j + 1];
    }

    inputNumbers[inputNumbers.Length - 1] = firstNumber;
}

Console.WriteLine(string.Join(" ", inputNumbers));
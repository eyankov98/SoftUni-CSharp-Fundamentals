int[] inputNumbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int currentEqualElementsCount = 0;
int equalElementsCount = 0;
int currentIndexElement = 0;

for (int i = 0; i < inputNumbers.Length; i++)
{
    currentEqualElementsCount = 0;

    for (int j = i; j < inputNumbers.Length; j++)
    {
        if (inputNumbers[i] == inputNumbers[j])
        {
            currentEqualElementsCount++;
        }
        else
        {
            break;
        }

        if (currentEqualElementsCount > equalElementsCount)
        {
            equalElementsCount = currentEqualElementsCount;
            currentIndexElement = inputNumbers[i];
        }
    }
}

for (int i = 1; i <= equalElementsCount; i++)
{
    Console.Write(currentIndexElement + " ");
}
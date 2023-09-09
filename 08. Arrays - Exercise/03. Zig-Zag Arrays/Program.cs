int n = int.Parse(Console.ReadLine());

int[] firstArray = new int[n];
int[] secondArray = new int[n];

for (int i = 0; i < n; i++)
{
    int[] currentNumbers = Console.ReadLine()
        .Split(" ")
        .Select(int.Parse)
        .ToArray();

    if (i % 2 == 0)
    {
        firstArray[i] = currentNumbers[0];
        secondArray[i] = currentNumbers[1];
    }
    else
    {
        secondArray[i] = currentNumbers[0];
        firstArray[i] = currentNumbers[1];
    }
}

Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray));
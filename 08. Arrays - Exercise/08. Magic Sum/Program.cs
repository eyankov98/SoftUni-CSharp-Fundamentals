int[] inputNumbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int number = int.Parse(Console.ReadLine());

for (int i = 0; i < inputNumbers.Length; i++)
{
    int currentNumber = inputNumbers[i];

    for (int j = i + 1; j < inputNumbers.Length; j++)
    {
        int sumOfNumbers = currentNumber + inputNumbers[j];

        if (sumOfNumbers == number)
        {
            Console.WriteLine(currentNumber + " " + inputNumbers[j]);
        }
    }
}
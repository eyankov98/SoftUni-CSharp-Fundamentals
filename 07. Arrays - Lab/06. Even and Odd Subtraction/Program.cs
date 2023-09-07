int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int evenSum = 0;
int oddSum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenSum = evenSum + numbers[i];
    }
    else
    {
        oddSum = oddSum + numbers[i];
    }
}

Console.WriteLine(evenSum - oddSum);
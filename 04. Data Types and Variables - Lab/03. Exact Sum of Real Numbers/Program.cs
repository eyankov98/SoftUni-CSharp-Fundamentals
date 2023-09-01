int numbersCount = int.Parse(Console.ReadLine());

decimal numbersSum = 0;

for (int i = 1; i <= numbersCount; i++)
{
    decimal inputNumber = decimal.Parse(Console.ReadLine());
    numbersSum += inputNumber;
}

Console.WriteLine($"{numbersSum}");
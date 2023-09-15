List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

int numbersCnt = numbers.Count;

int negativeNumsCnt = 0;

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] < 0)
    {
        negativeNumsCnt += 1;
        numbers.RemoveAt(i);
        i -= 1;
    }
}

if (negativeNumsCnt == numbersCnt)
{
    Console.WriteLine("empty");
}
else
{
    numbers.Reverse();
    Console.WriteLine(String.Join(" ", numbers));
}
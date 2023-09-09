int n = int.Parse(Console.ReadLine());

int[] wagons = new int[n];

int totalNumberOfPeople = 0;

for (int i = 0; i < wagons.Length; i++)
{
    int numberOfPeople = int.Parse(Console.ReadLine());

    wagons[i] = numberOfPeople;

    totalNumberOfPeople = totalNumberOfPeople + numberOfPeople;
}

Console.WriteLine(string.Join(" ", wagons));
Console.WriteLine(totalNumberOfPeople);
int inputNumber = int.Parse(Console.ReadLine());

for (int i = 2; i <= inputNumber; i++)
{
    bool isPrime = false;

    for (int j = 2; j <= i; j++)
    {
        if (i == j)
        {
            isPrime = true;
        }
        else if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine($"{i} -> true");
    }
    else
    {
        Console.WriteLine($"{i} -> false");
    }
}
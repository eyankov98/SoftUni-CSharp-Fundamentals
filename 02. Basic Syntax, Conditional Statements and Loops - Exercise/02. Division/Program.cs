int n = int.Parse(Console.ReadLine());

int number = 0;

if (n % 2 == 0)
{
    number = 2;
}

if (n % 3 == 0)
{
    number = 3;
}

if (n % 6 == 0)
{
    number = 6;
}

if (n % 7 == 0)
{
    number = 7;
}

if (n % 10 == 0)
{
    number = 10;
}

if (number == 0)
{
    Console.WriteLine("Not divisible");
}
else
{
    Console.WriteLine($"The number is divisible by {number}");
}
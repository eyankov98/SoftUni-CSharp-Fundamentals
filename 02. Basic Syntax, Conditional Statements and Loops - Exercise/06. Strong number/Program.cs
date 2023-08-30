int number = int.Parse(Console.ReadLine());

int strongNumber = number;
int sum = 0;

while (number != 0)
{
    int digit = number % 10;
    number = number / 10;

    int factoriel = 1;
    for (int i = 1; i <= digit; i++)
    {
        factoriel = factoriel * i;
    }

    sum = sum + factoriel;
}

if (sum == strongNumber)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
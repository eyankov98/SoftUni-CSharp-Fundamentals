int startingSpice = int.Parse(Console.ReadLine());

int days = 0;
int totalSpice = 0;

while (startingSpice >= 100)
{
    days++;
    totalSpice = totalSpice + startingSpice;
    totalSpice = totalSpice - 26;

    startingSpice = startingSpice - 10;
}

Console.WriteLine(days);
if (totalSpice < 26)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(totalSpice - 26);
}
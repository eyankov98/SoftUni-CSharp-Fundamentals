int currentHour = int.Parse(Console.ReadLine());
int currentMinute = int.Parse(Console.ReadLine());

if (currentMinute <= 29)
{
    Console.WriteLine($"{currentHour}:{currentMinute + 30}");
}
else
{
    if (currentHour == 23)
    {
        currentHour = 0;
    }
    else
    {
        currentHour++;
    }

    Console.WriteLine($"{currentHour}:{Math.Abs(currentMinute - 30):D2}");
}
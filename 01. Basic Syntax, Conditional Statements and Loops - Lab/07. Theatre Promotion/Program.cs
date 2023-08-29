﻿string typeDay = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

int ticketPrice = 0;

if (typeDay == "Weekday")
{
    if (age < 0 || age > 122)
    {
        Console.WriteLine("Error!");
        return;
    }
    else if (age <= 18)
    {
        ticketPrice = 12;
    }
    else if (age <= 64)
    {
        ticketPrice = 18;
    }
    else if (age <= 122)
    {
        ticketPrice = 12;
    }
}
else if (typeDay == "Weekend")
{
    if (age < 0 || age > 122)
    {
        Console.WriteLine("Error!");
        return;
    }
    else if (age <= 18)
    {
        ticketPrice = 15;
    }
    else if (age <= 64)
    {
        ticketPrice = 20;
    }
    else if (age <= 122)
    {
        ticketPrice = 15;
    }
}
else if (typeDay == "Holiday")
{
    if (age < 0 || age > 122)
    {
        Console.WriteLine("Error!");
        return;
    }
    else if (age <= 18)
    {
        ticketPrice = 5;
    }
    else if (age <= 64)
    {
        ticketPrice = 12;
    }
    else if (age <= 122)
    {
        ticketPrice = 10;
    }
}

Console.WriteLine($"{ticketPrice}$");
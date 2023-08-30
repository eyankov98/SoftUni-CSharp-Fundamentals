﻿int countOfPeople = int.Parse(Console.ReadLine());
string typeOfGroup = Console.ReadLine();
string dayOfWeek = Console.ReadLine();

double priceForOnePerson = 0;
double totalPrice = 0;

if (typeOfGroup == "Students")
{
    if (dayOfWeek == "Friday")
    {
        priceForOnePerson = 8.45;
    }
    else if (dayOfWeek == "Saturday")
    {
        priceForOnePerson = 9.80;
    }
    else if (dayOfWeek == "Sunday")
    {
        priceForOnePerson = 10.46;
    }

    totalPrice = countOfPeople * priceForOnePerson;

    if (countOfPeople >= 30)
    {
        totalPrice = totalPrice - totalPrice * 0.15;
    }
}
else if (typeOfGroup == "Business")
{
    if (dayOfWeek == "Friday")
    {
        priceForOnePerson = 10.90;
    }
    else if (dayOfWeek == "Saturday")
    {
        priceForOnePerson = 15.60;
    }
    else if (dayOfWeek == "Sunday")
    {
        priceForOnePerson = 16;
    }

    totalPrice = countOfPeople * priceForOnePerson;

    if (countOfPeople >= 100)
    {
        totalPrice = totalPrice - (10 * priceForOnePerson);
    }
}
else if (typeOfGroup == "Regular")
{
    if (dayOfWeek == "Friday")
    {
        priceForOnePerson = 15;
    }
    else if (dayOfWeek == "Saturday")
    {
        priceForOnePerson = 20;
    }
    else if (dayOfWeek == "Sunday")
    {
        priceForOnePerson = 22.50;
    }

    totalPrice = countOfPeople * priceForOnePerson;

    if (countOfPeople >= 10 && countOfPeople <= 20)
    {
        totalPrice = totalPrice - totalPrice * 0.05;
    }
}

Console.WriteLine($"Total price: {totalPrice:f2}");
﻿double inputNumberOne = double.Parse(Console.ReadLine());
double inputNumberTwo = double.Parse(Console.ReadLine());

float numberOneFloat = (float)inputNumberOne;
float numberTwoFloat = (float)inputNumberTwo;

if (numberOneFloat == numberTwoFloat)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
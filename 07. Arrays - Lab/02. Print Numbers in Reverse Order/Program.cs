﻿int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

for (int i = 0; i < numbers.Length; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    numbers[i] = currentNumber;
}

for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}
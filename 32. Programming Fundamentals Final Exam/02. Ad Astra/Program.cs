﻿using System.Text.RegularExpressions;

string inputString = Console.ReadLine();

Regex foodRegex = new Regex(@"(?<separator>#|\|)(?<itemName>[A-Za-z\s*]+)\k<separator>(?<expDate>\d{2}\/\d{2}\/\d{2})\k<separator>(?<calories>\d+)\k<separator>");

MatchCollection matches = foodRegex.Matches(inputString);

int totalCalories = 0;

foreach (Match match in matches)
{
    totalCalories += int.Parse(match.Groups["calories"].Value);
}

int daysToLast = totalCalories / 2000;

Console.WriteLine($"You have food to last you for: {daysToLast} days!");

foreach (Match match in matches)
{
    Console.WriteLine($"Item: {match.Groups["itemName"].Value}, Best before: {match.Groups["expDate"].Value}, Nutrition: {match.Groups["calories"].Value}");
}
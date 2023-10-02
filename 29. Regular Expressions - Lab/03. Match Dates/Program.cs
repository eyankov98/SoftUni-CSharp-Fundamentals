﻿using System.Text.RegularExpressions;

string input = Console.ReadLine();

string pattern = @"(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

Regex regex = new Regex(pattern);

MatchCollection matchCollection = regex.Matches(input);

foreach (Match match in matchCollection)
{
    var group = match.Groups;

    Console.WriteLine($"Day: {group["day"]}, Month: {group["month"]}, Year: {group["year"]}");
}
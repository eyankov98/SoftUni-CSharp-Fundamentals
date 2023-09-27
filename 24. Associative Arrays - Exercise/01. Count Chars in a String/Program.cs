﻿string inputWords = Console.ReadLine();
List<char> inputChars = new List<char>();
inputChars.AddRange(inputWords);

Dictionary<char, int> charCopies = new Dictionary<char, int>();

for (int i = 0; i < inputChars.Count; i++)
{
    if (inputChars[i] == 32)
    {
        inputChars.RemoveAt(i);
        i--;
    }
}

foreach (var currentChar in inputChars)
{
    if (!charCopies.ContainsKey(currentChar))
    {
        charCopies.Add(currentChar, 1);
    }
    else
    {
        charCopies[currentChar] += 1;
    }
}

foreach (var currentChar in charCopies)
{
    Console.WriteLine($"{currentChar.Key} -> {currentChar.Value}");
}
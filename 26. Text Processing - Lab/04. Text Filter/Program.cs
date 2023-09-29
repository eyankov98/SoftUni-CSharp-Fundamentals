string[] bannedWords = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string text = Console.ReadLine();

foreach (string banedWord in bannedWords)
{
    text = text.Replace(banedWord, new string('*', banedWord.Length));
}

Console.WriteLine(text);
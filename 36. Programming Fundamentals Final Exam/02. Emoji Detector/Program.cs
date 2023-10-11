using System.Text.RegularExpressions;

string input = Console.ReadLine();

string pattern = @"(\:\:|\*\*)(?<emoji>[A-Z][a-z]{2,})\1";

string patternDigit = @"[0-9]";

Regex regexOne = new Regex(pattern);

Regex regexTwo = new Regex(patternDigit);

MatchCollection matchCollectionOne = regexOne.Matches(input);

MatchCollection matchCollectionTwo = regexTwo.Matches(input);

int sumDigits = 1;

foreach (Match digit in matchCollectionTwo)
{
    int currentDigit = int.Parse(digit.Value);
    sumDigits = sumDigits * currentDigit;
}

Console.WriteLine($"Cool threshold: {sumDigits}");

Console.WriteLine($"{matchCollectionOne.Count} emojis found in the text. The cool ones are:");

foreach (Match emoji in matchCollectionOne)
{
    string validEmoji = emoji.Groups["emoji"].Value;

    int sum = 0;

    for (int i = 0; i < validEmoji.Length; i++)
    {
        sum = sum + validEmoji[i];
    }

    if (sum > sumDigits)
    {
        Console.WriteLine(emoji);
    }
}
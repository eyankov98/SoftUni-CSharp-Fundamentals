string[] words = Console.ReadLine()
    .Split(" ")
    .ToArray();

Dictionary<string, int> allWords = new Dictionary<string, int>();

foreach (string word in words)
{
    string wordsToLower = word.ToLower();

    if (!allWords.ContainsKey(wordsToLower))
    {
        allWords.Add(wordsToLower, 0);
    }

    allWords[wordsToLower]++;
}

var result = allWords
    .Where(x => x.Value % 2 != 0)
    .Select(x => x.Key)
    .ToList();

Console.WriteLine(string.Join(" ", result));
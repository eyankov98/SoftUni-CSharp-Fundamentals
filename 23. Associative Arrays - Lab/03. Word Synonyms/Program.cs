int n = int.Parse(Console.ReadLine());

Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

for (int i = 0; i < n; i++)
{
    string key = Console.ReadLine();
    string value = Console.ReadLine();

    if (!words.ContainsKey(key))
    {
        List<string> newWords = new List<string>();

        newWords.Add(value);

        words.Add(key, newWords);
    }
    else
    {
        words[key].Add(value);
    }
}

foreach (var word in words)
{
    Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
}
string[] words = Console.ReadLine()
    .Split(" ")
    .ToArray();

string result = string.Empty;

foreach (string word in words)
{
    for (int i = 0; i < word.Length; i++)
    {
        result = result + word;
    }
}

Console.WriteLine(result);
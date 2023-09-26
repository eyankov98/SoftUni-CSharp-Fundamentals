List<string> words = Console.ReadLine()
    .Split(" ")
    .Where(x => x.Length % 2 == 0)
    .ToList();

foreach (var word in words)
{
    Console.WriteLine(word);
}
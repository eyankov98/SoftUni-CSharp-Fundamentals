string[] words = Console.ReadLine()
    .Split(" ")
    .ToArray();

for (int i = 0; i < words.Length; i++)
{
    Random random = new Random();
    int randomindex = random.Next(0, words.Length);

    string currentWord = words[i];
    string wordToSwap = words[randomindex];

    words[i] = wordToSwap;
    words[randomindex] = currentWord;
}
Console.WriteLine(string.Join(Environment.NewLine, words));
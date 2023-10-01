char startChar = char.Parse(Console.ReadLine());
char endChar = char.Parse(Console.ReadLine());
string inputString = Console.ReadLine();

List<char> chars = new List<char>();
List<char> outputChars = new List<char>();

for (int i = startChar; i < endChar; i++)
{
    char currentChar = (char)i;
    chars.Add(currentChar);
}

int sum = 0;

for (int i = 0; i < chars.Count; i++)
{
    for (int j = 0; j < inputString.Length; j++)
    {
        if (chars[i] == inputString[j])
        {
            sum += chars[i];
        }
    }
}

Console.WriteLine(sum);
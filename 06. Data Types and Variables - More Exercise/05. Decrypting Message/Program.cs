int key = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

string message = string.Empty;
for (int i = 0; i < n; i++)
{
    char input = char.Parse(Console.ReadLine());

    int outputIntValue = input + key;
    char outputChar = (char)outputIntValue;
    message += outputChar;
}

Console.WriteLine(message);
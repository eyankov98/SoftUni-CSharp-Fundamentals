using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());

List<int> numbers = new List<int>();

string pattern = @"@#+[A-Z][a-zA-Z(?<numbers>\d)]{4,}[A-Z]@#+";

Regex regex = new Regex(pattern);

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    Match match = regex.Match(input);

    if (match.Success)
    {
        bool hasDigit = false;

        Console.Write("Product group: ");

        for (int j = 0; j < input.Length; j++)
        {
            if (char.IsDigit(input[j]))
            {
                hasDigit = true;

                Console.Write(input[j]);
            }
        }

        if (!hasDigit)
        {
            Console.Write("00");
        }

        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Invalid barcode");
    }
}
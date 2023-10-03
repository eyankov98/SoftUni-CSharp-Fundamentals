using System.Text.RegularExpressions;

string input = string.Empty;

Regex regex = new Regex(@"\B>>(?<furniture>[A-z]+)<<(?<price>\d+(\.*\d*))!(?<quantity>\d+)");

List<string> purchasedItems = new List<string>();

double sum = 0;

while ((input = Console.ReadLine()) != "Purchase")
{
    MatchCollection purchase = regex.Matches(input);

    foreach (Match item in purchase)
    {
        string name = item.Groups["furniture"].Value;
        double price = double.Parse(item.Groups["price"].Value);
        int quantity = int.Parse(item.Groups["quantity"].Value);
        purchasedItems.Add(name);
        sum += price * quantity;
    }
}

Console.WriteLine("Bought furniture:");

if (purchasedItems.Count > 0)
{
    Console.WriteLine(String.Join("\n", purchasedItems));
}

Console.WriteLine($"Total money spend: {sum:f2}");
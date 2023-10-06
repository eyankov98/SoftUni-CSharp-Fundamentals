using System.Text.RegularExpressions;

string input = Console.ReadLine();

List<string> places = new List<string>();

int travelPoints = 0;

string pattern = @"(?<separator>=|\/)(?<location>[A-Z][A-Za-z]{2,})\1";

Regex regex = new Regex(pattern);

MatchCollection matchCollection = regex.Matches(input);

foreach (Match place in matchCollection)
{
    var location = place.Groups["location"].Value;
    travelPoints = travelPoints + location.Length;

    places.Add(location);
}

Console.WriteLine($"Destinations: {string.Join(", ", places)}");
Console.WriteLine($"Travel Points: {travelPoints}");
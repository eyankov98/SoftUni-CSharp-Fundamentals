using System.Text.RegularExpressions;
using System.Text;

List<string> participantsInputList = Console.ReadLine()
    .Split(", ")
    .ToList();

Regex nameRegex = new Regex(@"[A-Za-z]");
Regex distanceRegex = new Regex(@"\d");

Dictionary<string, int> participants = new Dictionary<string, int>();

int sum = 0;
string command = string.Empty;

while ((command = Console.ReadLine()) != "end of race")
{
    MatchCollection nameMatch = nameRegex.Matches(command);
    MatchCollection distanceNumbers = distanceRegex.Matches(command);

    StringBuilder name = new StringBuilder();
    foreach (Match character in nameMatch)
    {
        name.Append(character.Value);
    }
    string currentName = name.ToString();

    if (participantsInputList.Contains(currentName.ToString()))
    {
        foreach (Match num in distanceNumbers)
        {
            sum += int.Parse(num.Value);
        }

        if (participants.ContainsKey(currentName))
        {
            participants[currentName] += sum;
        }
        else
        {
            participants.Add(currentName, sum);
        }
    }

    sum = 0;
}

int commandsMade = 0;
foreach (var participant in participants.OrderByDescending(key => key.Value))
{
    commandsMade++;
    if (commandsMade == 1)
    {
        Console.WriteLine($"1st place: {participant.Key}");
    }
    else if (commandsMade == 2)
    {
        Console.WriteLine($"2nd place: {participant.Key}");
    }
    else if (commandsMade == 3)
    {
        Console.WriteLine($"3rd place: {participant.Key}");
    }
}
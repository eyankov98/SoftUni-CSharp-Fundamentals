List<string> treasureChest = Console.ReadLine()
    .Split("|")
    .ToList();

string command = string.Empty;
while ((command = Console.ReadLine()) != "Yohoho!")
{
    string[] commandArray = command.Split();

    if (commandArray[0] == "Loot")
    {
        for (int i = 1; i < commandArray.Length; i++)
        {
            if (treasureChest!.Contains(commandArray[i]))
            {
            }
            else
            {
                treasureChest.Insert(0, commandArray[i]);
            }
        }
    }
    else if (commandArray[0] == "Drop")
    {
        int index = int.Parse(commandArray[1]);

        if (index >= 0 && index < treasureChest.Count)
        {
            string currentLoot = treasureChest[index];
            treasureChest.RemoveAt(index);
            treasureChest.Add(currentLoot);
        }
    }
    else if (commandArray[0] == "Steal")
    {
        int stealItemsCount = int.Parse(commandArray[1]);

        while (stealItemsCount > treasureChest.Count)
        {
            stealItemsCount--;
        }
        List<string> stolenItemsList = new List<string>();

        for (int i = treasureChest.Count - stealItemsCount; i < treasureChest.Count; i++)
        {
            stolenItemsList.Add(treasureChest[i]);
        }

        treasureChest.RemoveRange(treasureChest.Count - stealItemsCount, stealItemsCount);

        Console.WriteLine(String.Join(", ", stolenItemsList));
    }
}

double sum = 0;

for (int i = 0; i < treasureChest.Count; i++)
{
    string currentString = treasureChest[i];
    sum += currentString.Length;
}
sum /= treasureChest.Count;

if (treasureChest.Count > 0)
{
    Console.WriteLine($"Average treasure gain: {sum:f2} pirate credits.");
}
else
{
    Console.WriteLine("Failed treasure hunt.");
}
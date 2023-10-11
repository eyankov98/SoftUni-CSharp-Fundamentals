string command = string.Empty;

List<City> citiesList = new List<City>();

while ((command = Console.ReadLine()) != "Sail")
{
    string[] commandArray = command.Split("||");
    string cityName = commandArray[0];
    int population = int.Parse(commandArray[1]);
    int gold = int.Parse(commandArray[2]);

    City currentCity = new City(cityName, population, gold);
    bool alreadyCity = false;

    if (citiesList.Count == 0)
    {
        citiesList.Add(currentCity);
    }
    else
    {
        for (int i = 0; i < citiesList.Count; i++)
        {
            if (citiesList[i].Name == cityName)
            {
                alreadyCity = true;
                citiesList[i].Population += population;
                citiesList[i].Gold += gold;
            }
        }
        if (!alreadyCity)
        {
            citiesList.Add(currentCity);
        }
    }
}

while ((command = Console.ReadLine()) != "End")
{
    string[] commandArray = command.Split("=>");
    string commandType = commandArray[0];

    if (commandType == "Plunder")
    {
        string town = commandArray[1];
        int people = int.Parse(commandArray[2]);
        int gold = int.Parse(commandArray[3]);

        for (int i = 0; i < citiesList.Count; i++)
        {
            if (citiesList[i].Name == town)
            {
                citiesList[i].Population -= people;
                citiesList[i].Gold -= gold;
                Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
            }
            if (citiesList[i].Population <= 0 || citiesList[i].Gold <= 0)
            {
                citiesList.Remove(citiesList[i]);
                Console.WriteLine($"{town} has been wiped off the map!");
            }
        }
    }
    else if (commandType == "Prosper")
    {
        string town = commandArray[1];
        int gold = int.Parse(commandArray[2]);

        if (gold < 0)
        {
            Console.WriteLine("Gold added cannot be a negative number!");
        }
        else
        {
            for (int i = 0; i < citiesList.Count; i++)
            {
                if (citiesList[i].Name == town)
                {
                    citiesList[i].Gold += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {citiesList[i].Gold} gold.");
                }
            }
        }
    }
}

if (citiesList.Count == 0)
{
    Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
}
else
{
    Console.WriteLine($"Ahoy, Captain! There are {citiesList.Count} wealthy settlements to go to:");
    foreach (var town in citiesList)
    {
        Console.WriteLine($"{town.Name} -> Population: {town.Population} citizens, Gold: {town.Gold} kg");
    }
}

public class City
{
    public string Name { get; set; }
    public int Population { get; set; }
    public int Gold { get; set; }

    public City(string name, int population, int gold)
    {
        Name = name;
        Population = population;
        Gold = gold;
    }
}
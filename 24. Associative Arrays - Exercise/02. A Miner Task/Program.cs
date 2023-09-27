string info = string.Empty;

Dictionary<string, int> resources = new Dictionary<string, int>();

while ((info = Console.ReadLine()) != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    if (!resources.ContainsKey(info))
    {
        resources.Add(info, quantity);
    }
    else
    {
        resources[info] += quantity;
    }
}

foreach (var resource in resources)
{
    Console.WriteLine($"{resource.Key} -> {resource.Value}");
}
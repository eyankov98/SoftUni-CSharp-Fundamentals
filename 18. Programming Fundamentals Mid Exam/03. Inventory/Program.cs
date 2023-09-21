namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> itemsList = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] commandArray = command
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commandArray[0] == "Collect")
                {
                    string item = commandArray[1];
                    bool itemContains = false;

                    for (int i = 0; i < itemsList.Count; i++)
                    {
                        if (itemsList[i] == item)
                        {
                            itemContains = true;
                            break;
                        }
                    }
                    if (itemContains == false)
                    {
                        itemsList.Add(item);
                    }
                }
                else if (commandArray[0] == "Drop")
                {
                    string item = commandArray[1];

                    for (int i = 0; i < itemsList.Count; i++)
                    {
                        if (itemsList[i] == item)
                        {
                            itemsList.RemoveAt(i);
                        }
                    }
                }
                else if (commandArray[0] == "Combine Items")
                {
                    string[] itemsArray = commandArray[1].Split(":").ToArray();
                    string oldItem = itemsArray[0];
                    string newItem = itemsArray[1];

                    for (int i = 0; i < itemsList.Count; i++)
                    {
                        if (itemsList[i] == oldItem)
                        {
                            itemsList.Insert(i + 1, newItem);
                        }
                    }
                }
                else if (commandArray[0] == "Renew")
                {
                    string item = commandArray[1];

                    for (int i = 0; i < itemsList.Count; i++)
                    {
                        if (itemsList[i] == item)
                        {
                            itemsList.RemoveAt(i);
                            itemsList.Add(item);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(", ", itemsList));
        }
    }
}
namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                .Split("!")
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                List<string> commandArray = new List<string>(command.Split(' '));

                if (command.Contains("Urgent"))
                {
                    string item = commandArray[1].ToString();
                    bool containsProduct = false;

                    for (int i = 0; i < shoppingList.Count; i++)
                    {
                        if (shoppingList[i] == item)
                        {
                            containsProduct = true;
                            break;
                        }
                    }
                    if (containsProduct == false)
                    {
                        shoppingList.Insert(0, item);
                    }
                }
                else if (command.Contains("Unnecessary"))
                {
                    string item = commandArray[1].ToString();

                    for (int i = 0; i < shoppingList.Count; i++)
                    {
                        if (shoppingList[i] == item)
                        {
                            shoppingList.Remove(item);
                        }
                    }
                }
                else if (command.Contains("Correct"))
                {
                    string oldItem = commandArray[1].ToString();
                    string newItem = commandArray[2].ToString();

                    for (int i = 0; i < shoppingList.Count; i++)
                    {
                        if (shoppingList[i] == oldItem)
                        {
                            shoppingList[i] = newItem;
                        }
                    }
                }
                else if (command.Contains("Rearrange"))
                {
                    string item = commandArray[1].ToString();

                    for (int i = 0; i < shoppingList.Count; i++)
                    {
                        if (shoppingList[i] == item)
                        {
                            shoppingList.RemoveAt(i);
                            shoppingList.Add(item);
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(", ", shoppingList));
        }
    }
}
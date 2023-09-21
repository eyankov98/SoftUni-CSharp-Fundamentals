namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> dungeonRooms = Console.ReadLine()
                .Split("|")
                .ToList();

            int initialHealth = 100;
            int initialBitcoins = 0;
            int bestRoom = 0;

            for (int i = 0; i < dungeonRooms.Count; i++)
            {
                bestRoom = i;

                string[] currentRoom = dungeonRooms[i].Split();
                int number = Convert.ToInt32(currentRoom[1].ToString());

                if (currentRoom[0] == "potion")
                {
                    if (initialHealth + number <= 100)
                    {
                        initialHealth += number;
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {100 - initialHealth} hp.");
                        initialHealth = 100;
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                }
                else if (currentRoom[0] == "chest")
                {
                    Console.WriteLine($"You found {number} bitcoins.");
                    initialBitcoins += number;
                }
                else
                {
                    initialHealth -= number;

                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {currentRoom[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {currentRoom[0]}.");
                        bestRoom++;
                        Console.WriteLine($"Best room: {bestRoom}");
                        break;
                    }
                }
            }

            if (initialHealth > 0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {initialBitcoins}");
                Console.WriteLine($"Health: {initialHealth}");
            }
        }
    }
}
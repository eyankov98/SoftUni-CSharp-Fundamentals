// 1. Initialize empty field
int n = int.Parse(Console.ReadLine()); // Field size

int[] field = new int[n];

// 2. Spawn ladybugs on the valid indexes
// This collection remains unchanged => we can use foreach !
int[] initialIndexes = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

foreach (int index in initialIndexes)
{
    if (index >= 0 && index < field.Length)
    {
        field[index] = 1;
    }
}

// 3. Proceed game moves (start game)

string command;

while ((command = Console.ReadLine()) != "end")
{
    string[] commandArguments = command.Split(" ").ToArray();

    int ladybugIndex = int.Parse(commandArguments[0]);
    string direction = commandArguments[1];
    int flyLength = int.Parse(commandArguments[2]);

    // 3.1 Validate ladybugIndex is inside the field!
    if (ladybugIndex < 0 || ladybugIndex >= field.Length)
    {
        // Invalid index => Nothing happens
        continue;
    }

    // 3.2 Validate ladybugIndex contains ladybug
    if (field[ladybugIndex] == 0)
    {
        // There is no ladybug there => Nothing happens
        continue;
    }

    // 3.3 Try to proceed move
    // Rigth -> ladybugIndex + flyLength
    // Left -> ladybugIndex - flyLength 

    // First -> Our ladybug starts flying => it removes from the field, becouse it is in the air !
    field[ladybugIndex] = 0;

    if (direction == "left")
    {
        flyLength = flyLength * -1; // 1 => -1
    }

    // 0 Right 1 => 0 + 1 = 1
    // 1 Left 1 => 1 + (-1) = 0
    int nextIndex = ladybugIndex + flyLength;

    while (nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 1)
    {
        nextIndex = nextIndex + flyLength;
    }

    // There are two possibilities:
    // Variant a: nextIndex is calculated somewhere in the field
    //Variant b: nexIndex cannot be calculated in the field
    if (nextIndex < 0 || nextIndex >= field.Length)
    {
        // Variant b
        // Outside of the field
        continue;
    }

    // Variant a
    // Land the ladybug on the valid next index
    field[nextIndex] = 1;
}

Console.WriteLine(string.Join(" ", field));
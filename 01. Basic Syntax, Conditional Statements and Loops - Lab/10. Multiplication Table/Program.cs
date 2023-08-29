int chosenNumber = int.Parse(Console.ReadLine());

int multiplicationNumber = 0;

for (int i = 1; i <= 10; i++)
{
    multiplicationNumber = i;
    Console.WriteLine($"{chosenNumber} X {multiplicationNumber} = {chosenNumber * multiplicationNumber}");
}
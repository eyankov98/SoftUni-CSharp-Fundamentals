int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());

int studentsCount = int.Parse(Console.ReadLine());

int hoursCount = 0;

int answersStudentsForHour = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;

while (studentsCount > 0)
{
    hoursCount++;

    studentsCount = studentsCount - answersStudentsForHour;

    if (hoursCount % 4 == 0)
    {
        hoursCount++;
    }
}
Console.WriteLine($"Time needed: {hoursCount}h.");
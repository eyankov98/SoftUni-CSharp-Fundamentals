int numberOfPeople = int.Parse(Console.ReadLine());
int capacity = int.Parse(Console.ReadLine());

int courses = numberOfPeople / capacity;

if (numberOfPeople % capacity != 0)
{
    courses = courses + 1;
}

Console.WriteLine(courses);
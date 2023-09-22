﻿string input = Console.ReadLine();

List<Student> students = new List<Student>();

while (input != "end")
{
    string[] infoArray = input
        .Split(" ")
        .ToArray();

    string firstName = infoArray[0];
    string lastName = infoArray[1];
    int age = int.Parse(infoArray[2]);
    string town = infoArray[3];

    Student student = new Student
    {
        FirstName = firstName,
        LastName = lastName,
        Age = age,
        HomeTown = town,
    };

    students.Add(student);

    input = Console.ReadLine();
}

string homeTown = Console.ReadLine();

foreach (Student currentStudent in students)
{
    if (currentStudent.HomeTown == homeTown)
    {
        Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
    }
}
class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string HomeTown { get; set; }
}
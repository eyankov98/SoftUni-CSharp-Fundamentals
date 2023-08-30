double amounOfMoney = double.Parse(Console.ReadLine());
int countOfStudents = int.Parse(Console.ReadLine());
double priceOfLightsaber = double.Parse(Console.ReadLine());
double priceOfRobe = double.Parse(Console.ReadLine());
double priceOfBelt = double.Parse(Console.ReadLine());

int countOfLightsaber = countOfStudents;
int countOfRobe = countOfStudents;
int countOfBelt = countOfStudents;

double extraLightsaber = Math.Ceiling(countOfLightsaber * 0.10);
int freeBelsts = countOfBelt / 6;

countOfLightsaber = countOfLightsaber + (int)extraLightsaber;
countOfBelt = countOfBelt - freeBelsts;

double totalSum = (countOfLightsaber * priceOfLightsaber) + (countOfBelt * priceOfBelt) + (countOfRobe * priceOfRobe); ;

if (totalSum > amounOfMoney)
{
    double result = totalSum - amounOfMoney;
    Console.WriteLine($"John will need {result:f2}lv more.");
}
else
{
    Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
}
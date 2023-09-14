﻿namespace _02._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());

                if (FirstPointCoordinates(x1, y1) < SecondPointCoordinates(x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})");
                }
                else if (FirstPointCoordinates(x1, y1) > SecondPointCoordinates(x2, y2))
                {
                    Console.WriteLine($"({x2}, {y2})");
                }
                else if (FirstPointCoordinates(x1, y1) == SecondPointCoordinates(x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})");
                }
            }

            static double FirstPointCoordinates(double firstNum, double secondNum)
            {
                return Math.Abs(firstNum) + Math.Abs(secondNum);
            }
            static double SecondPointCoordinates(double firstNum, double secondNum)
            {
                return Math.Abs(firstNum) + Math.Abs(secondNum);
            }
        }
    }
}
﻿int[] stepLines = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int indexFinishLine = stepLines.Length / 2;
double leftRacerTimeSum = 0;
double rightRacerTimeSum = 0;

for (int i = 0; i < indexFinishLine; i++)
{
    if (stepLines[i] == 0)
    {
        leftRacerTimeSum -= leftRacerTimeSum * 0.2;
    }
    else
    {
        leftRacerTimeSum += stepLines[i];
    }
}

for (int j = stepLines.Length - 1; j > indexFinishLine; j--)
{
    if (stepLines[j] == 0)
    {
        rightRacerTimeSum -= rightRacerTimeSum * 0.2;
    }
    else
    {
        rightRacerTimeSum += stepLines[j];
    }
}

if (leftRacerTimeSum > rightRacerTimeSum)
{
    Console.WriteLine($"The winner is right with total time: {rightRacerTimeSum}");
}
else
{
    Console.WriteLine($"The winner is left with total time: {leftRacerTimeSum}");
}
int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());

int startingPower = N;
int countOfTargets = 0;

while (N >= M)
{
    N = N - M;
    countOfTargets++;

    if (N * 2 == startingPower && Y != 0)
    {
        N = N / Y;
    }
}

Console.WriteLine(N);
Console.WriteLine(countOfTargets);
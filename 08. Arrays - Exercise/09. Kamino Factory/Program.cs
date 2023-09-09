int dnaLength = int.Parse(Console.ReadLine());

string command;
int[] outputDna = new int[dnaLength];

int sample = 0;
int bestSample = 0;

int sequenceCount = 1;
int bestCnt = 0;

int currentSum = 0;
int bestSum = 0;

int bestIndex = 0;
int currentIndex = 0;

while ((command = Console.ReadLine()) != "Clone them!")
{
    sample++;

    int[] dna = command.Split("!", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    currentSum = 0;
    sequenceCount = 1;

    for (int i = 0; i < dna.Length - 1; i++)
    {
        if (dna[i] == 1 && dna[i] == dna[i + 1])
        {
            if (sequenceCount == 1)
            {
                currentIndex = i;
            }
            sequenceCount++;
        }
    }

    for (int i = 0; i < dna.Length; i++)
    {
        if (dna[i] == 1)
        {
            currentSum++;
        }
    }

    if (sequenceCount > bestCnt)
    {
        bestCnt = sequenceCount;
        outputDna = dna;
        bestSample = sample;
        bestSum = currentSum;
        bestIndex = currentIndex;
    }
    else if (sequenceCount == bestCnt)
    {
        if (currentIndex < bestIndex)
        {
            outputDna = dna;
            bestSample = sample;
            bestSum = currentSum;
            bestIndex = currentIndex;
        }
        else if (currentIndex == bestIndex)
        {
            if (currentSum > bestSum)
            {
                outputDna = dna;
                bestSample = sample;
                bestSum = currentSum;
            }
        }
    }
}

Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
Console.WriteLine(string.Join(" ", outputDna));
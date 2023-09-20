namespace _01._Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal foodInKilograms = decimal.Parse(Console.ReadLine());
            decimal hayInKilograms = decimal.Parse(Console.ReadLine());
            decimal coverInKilograms = decimal.Parse(Console.ReadLine());
            decimal pigWeightInKilograms = decimal.Parse(Console.ReadLine());

            for (int i = 1; i <= 30; i++)
            {
                foodInKilograms -= 0.3m;

                if (i % 2 == 0)
                {
                    hayInKilograms -= foodInKilograms * 0.05m;
                }
                if (i % 3 == 0)
                {
                    coverInKilograms -= pigWeightInKilograms / 3.0m;
                }

                if (foodInKilograms <= 0 || hayInKilograms <= 0 || coverInKilograms <= 0)
                {
                    break;
                }
            }

            if (foodInKilograms <= 0 || hayInKilograms <= 0 || coverInKilograms <= 0)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodInKilograms:f2}, Hay: {hayInKilograms:f2}, Cover: {coverInKilograms:f2}.");
            }
        }
    }
}
namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double maxBonus = double.MinValue;
            int maxBonusStudentAttendances = 0;

            if (studentsCount == 0 || lecturesCount == 0)
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");
                return;
            }

            for (int i = 1; i <= studentsCount; i++)
            {
                int studentAttendances = int.Parse(Console.ReadLine());

                double totalBonus = ((double)studentAttendances / lecturesCount) *
                    (5 + additionalBonus);

                if (maxBonus < totalBonus)
                {
                    maxBonus = totalBonus;
                    maxBonusStudentAttendances = studentAttendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxBonusStudentAttendances} lectures.");
        }
    }
}
namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> initialSchedule = Console.ReadLine().Split(", ").ToList();

            string command;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] input = command.Split(":");

                if (input[0] == "Add")
                {
                    if (FindLesson(initialSchedule, input[1]))
                    {
                        initialSchedule.Add(input[1]);
                    }
                }
                else if (input[0] == "Insert")
                {
                    if (FindLesson(initialSchedule, input[1]))
                    {
                        initialSchedule.Insert(int.Parse(input[2]), input[1]);
                    }
                }
                else if (input[0] == "Remove")
                {
                    if (!FindLesson(initialSchedule, input[1]))
                    {
                        initialSchedule.Remove(input[1]);
                    }
                }
                else if (input[0] == "Swap")
                {
                    if (!FindLesson(initialSchedule, input[1]) && !FindLesson(initialSchedule, input[2]))
                    {


                        if (FindExercise(initialSchedule, input[1]))
                        {

                            for (int i = 0; i < initialSchedule.Count; i++)
                            {
                                if (initialSchedule[i] == input[1])
                                {
                                    initialSchedule[i] = input[2];
                                    initialSchedule.RemoveAt(i + 1);
                                }
                                else if (initialSchedule[i] == input[2])
                                {
                                    initialSchedule[i] = input[1];
                                    initialSchedule.Insert((i + 1), $"{initialSchedule[i]}-Exercise");
                                }
                            }
                        }
                        else if (FindExercise(initialSchedule, input[2]))
                        {
                            for (int i = 0; i < initialSchedule.Count; i++)
                            {
                                if (initialSchedule[i] == input[1])
                                {
                                    initialSchedule[i] = input[2];
                                    initialSchedule.Insert((i + 1), $"{initialSchedule[i]}-Exercise");

                                }
                                else if (initialSchedule[i] == input[2])
                                {

                                    initialSchedule[i] = input[1];
                                    initialSchedule.RemoveAt(i + 1);
                                }

                            }
                        }
                        else
                        {
                            for (int i = 0; i < initialSchedule.Count; i++)
                            {
                                if (initialSchedule[i] == input[1])
                                {
                                    initialSchedule[i] = input[2];
                                }
                                else if (initialSchedule[i] == input[2])
                                {
                                    initialSchedule[i] = input[1];
                                }

                            }

                        }

                    }
                }
                else if (input[0] == "Exercise")
                {
                    if (!FindLesson(initialSchedule, input[1]) && !FindExercise(initialSchedule, input[1]))
                    {
                        for (int i = 0; i < initialSchedule.Count; i++)
                        {
                            if (initialSchedule[i] == input[1])
                            {
                                initialSchedule.Insert(i + 1, $"{input[1]}-Exercise");
                            }
                        }
                    }
                    else if (!FindLesson(initialSchedule, input[1]) && FindExercise(initialSchedule, input[1]))
                    {
                        continue;
                    }
                    else
                    {
                        initialSchedule.Add(input[1]);
                        initialSchedule.Add($"{input[1]}-Exercise");
                    }
                }
            }

            int index = 1;

            foreach (string item in initialSchedule)
            {
                Console.WriteLine($"{index}.{item}");
                index++;
            }
        }

        static bool FindLesson(List<string> schedule, string input)
        {
            if (schedule.Contains(input))
            {
                return false;
            }

            return true;
        }

        static bool FindExercise(List<string> schedule, string input)
        {
            for (int i = 0; i < schedule.Count; i++)
            {
                string[] currentLesson = schedule[i].Split("-");

                if (currentLesson.Length == 2)
                {
                    if (currentLesson[1] == "Exercise" && currentLesson[0] == input)
                    {
                        return true;
                    }
                }

            }

            return false;
        }

    }
}
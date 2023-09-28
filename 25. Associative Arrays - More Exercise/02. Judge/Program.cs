namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            Dictionary<string, Dictionary<string, int>> courseRegister = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> usersStats = new Dictionary<string, Dictionary<string, int>>();
            SortedDictionary<string, int> totalPointsByUser = new SortedDictionary<string, int>();

            while ((command = Console.ReadLine()) != "no more time")
            {
                string[] inputArg = command.Split(" -> ");
                string user = inputArg[0];
                string course = inputArg[1];
                int points = int.Parse(inputArg[2]);

                if (!usersStats.ContainsKey(user))
                {
                    usersStats.Add(user, new Dictionary<string, int>());

                }

                if (!usersStats[user].ContainsKey(course))
                {
                    usersStats[user].Add(course, points);
                }


                if (usersStats[user][course] < points)
                {
                    usersStats[user][course] = points;
                }



                AddNewUser(courseRegister, user, course, points);
            }

            foreach (var user in usersStats)
            {
                totalPointsByUser.Add(user.Key, 0);

                foreach (var item in user.Value)
                {
                    totalPointsByUser[user.Key] += item.Value;
                }
            }

            foreach (var course in courseRegister)
            {
                int counter = 1;
                Console.WriteLine($"{course.Key}: {course.Value.Count} participants");

                foreach (var user in course.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{counter++}. {user.Key} <::> {user.Value}");
                }
            }

            Console.WriteLine("Individual standings:");


            int counter1 = 1;
            foreach (var user in totalPointsByUser.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{counter1++}. {user.Key} -> {user.Value}");
            }
        }

        private static void AddNewUser(Dictionary<string, Dictionary<string, int>> courseRegister, string user, string course, int points)
        {
            if (!courseRegister.ContainsKey(course))
            {
                courseRegister.Add(course, new Dictionary<string, int>());
            }

            if (!courseRegister[course].ContainsKey(user))
            {

                courseRegister[course].Add(user, points);
            }

            if (courseRegister[course][user] < points)
            {
                courseRegister[course][user] = points;
            }
        }
    }
}
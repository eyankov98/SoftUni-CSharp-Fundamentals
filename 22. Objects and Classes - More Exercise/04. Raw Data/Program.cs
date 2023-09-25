namespace _04._Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = cmd[0];
                int engineSpeed = int.Parse(cmd[1]);
                int enginePower = int.Parse(cmd[2]);
                int cargoWeight = int.Parse(cmd[3]);
                string cargoType = cmd[4];

                Engine engine = new Engine()
                {
                    EngineSpeed = engineSpeed,
                    EnginePower = enginePower
                };

                Cargo cargo = new Cargo()
                {
                    CargoWeight = cargoWeight,
                    CargoType = cargoType
                };

                Car car = new Car(model, engine, cargo);

                cars.Add(car);
            }

            string crgType = Console.ReadLine();

            if (crgType == "fragile")
            {
                foreach (var car in cars.Where(x => x.Cargo.CargoType == "fragile" &&
                                                    x.Cargo.CargoWeight < 1000))
                {
                    Console.WriteLine($"{car.Model}");
                }

            }
            else if (crgType == "flamable")
            {
                foreach (var car in cars.Where(x => x.Cargo.CargoType == "flamable" &&
                                                    x.Engine.EnginePower > 250))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }

        public class Car
        {
            public Car(string Mdl, Engine engine, Cargo cargo)
            {
                Model = Mdl;
                Engine = engine;
                Cargo = cargo;
            }

            public string Model { get; set; }

            public Engine Engine { get; set; }

            public Cargo Cargo { get; set; }
        }

        public class Engine
        {
            public int EngineSpeed { get; set; }

            public int EnginePower { get; set; }
        }

        public class Cargo
        {
            public int CargoWeight { get; set; }

            public string CargoType { get; set; }
        }
    }
}
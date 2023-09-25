namespace _03._Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = data[0];
                double fuelAmount = double.Parse(data[1]);
                double fuelConsumption = double.Parse(data[2]);

                Car currentCar = new Car(model, fuelAmount, fuelConsumption);

                cars.Add(currentCar);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                else
                {
                    string[] data = input
                        .Split(' ')
                        .ToArray();

                    string model = data[1];
                    double amountKm = double.Parse(data[2]);

                    Car carForDriving = cars
                        .Where(x => x.Model == model)
                        .ToList()
                        .First();

                    carForDriving.CanIReachTheDistance(model, amountKm);
                }
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TravelledDistance}");
            }
        }

        public class Car
        {
            string model;
            double fuelAmount;
            double fuelConsumptionPerKilometer;
            double travelledDistance;

            public Car()
            {
            }

            public Car(string model, double fuelAmount, double fuelConsumption)
            {
                this.Model = model;
                this.FuelAmount = fuelAmount;
                this.FuelConsumptionPerKilometer = fuelConsumption;
                this.TravelledDistance = 0;
            }

            public string Model
            {
                get
                {
                    return model;
                }
                set
                {
                    this.model = value;
                }
            }

            public double FuelAmount
            {
                get
                {
                    return fuelAmount;
                }
                set
                {
                    this.fuelAmount = value;
                }
            }

            public double FuelConsumptionPerKilometer
            {
                get
                {
                    return fuelConsumptionPerKilometer;
                }
                set
                {
                    this.fuelConsumptionPerKilometer = value;
                }
            }

            public double TravelledDistance
            {
                get
                {
                    return travelledDistance;
                }
                set
                {
                    this.travelledDistance = value;
                }
            }

            public void CanIReachTheDistance(string model, double amountKm)
            {
                double neededLitres = amountKm * this.FuelConsumptionPerKilometer;

                if (this.FuelAmount >= neededLitres)
                {
                    this.fuelAmount -= neededLitres;
                    this.TravelledDistance += amountKm;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
        }
    }
}
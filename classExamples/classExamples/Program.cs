using System;

namespace classExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Toyota";
            myCar.Model = "Tundra";
            myCar.Year = 1989;
            myCar.Color = "Charcoal";

            Console.Write("Current Car: ");
            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

            Car userCar = new Car();

            Console.WriteLine("Getting a new car. What should the make be? ");
            userCar.Make = Console.ReadLine();
            Console.WriteLine("Model?");
            userCar.Model = Console.ReadLine();
            userCar.Year = 2018;
            Console.WriteLine("Color?");
            userCar.Color = Console.ReadLine();

            Console.WriteLine("Your new car: ");
            Console.WriteLine("{0} {1} {2} {3}", userCar.Make, userCar.Model, userCar.Year, userCar.Color);
            Console.ReadLine();


            Console.WriteLine("Old car value: {0:C}", myCar.DetermineMarketValue(myCar));
            Console.WriteLine("New car value: {0:C}", userCar.DetermineMarketValue(userCar));

            Console.ReadLine();

        }
    class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public decimal DetermineMarketValue(Car car)
            {
                decimal carValue;
                if (Year > 1990)
                    carValue = 10000;
                else
                    carValue = 2000;


                return carValue;
            }


        }
    }
}

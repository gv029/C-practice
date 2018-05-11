using System;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating new instance of the Car class
            Car myCar = new Car();
            Console.WriteLine(myCar.Make);
            Console.ReadLine();

            //Overloaded constructer demo
            Car myThirdCar = new Car("Nissan", "Altima", 1999, "Grey");
            Console.WriteLine(myThirdCar.Model);
            Console.ReadLine();

            //static method demo
            Car.myMethod();

            //Static class Bicycle with a static method
            Bicycle.myBikeMessage();

        }

        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public Car()
            {

            }

            public Car(string make, string model, int year, string color)
            {
                Make = make;
                Model = model;
                Year = year;
                Color = color;

            }
            public static void myMethod()
            {
                Console.WriteLine("Called static myMethod");
                Console.ReadLine();
            }


        }
        public static class Bicycle
        {
            public static void myBikeMessage()
            {
                Console.WriteLine("Bicycles are awesome! I love bikes. This method is within a static Class");
                Console.ReadLine();
            }
        }
    }
}

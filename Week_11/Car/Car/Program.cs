namespace Car;
using System;
using Car;

    class Program
    {
        static void Main(string[] args)
        {
            Dashboard dashboard = new Dashboard();

            // Adding some initial cars
            dashboard.AddCar(new Car("Model X", 18, "All-Season", 4));
            dashboard.AddCar(new Car("Model Y", 20, "Performance", 4));

            // Displaying cars
            dashboard.DisplayCars();

            // Inputting a new car model
            dashboard.InputNewModel();

            // Displaying cars again to show the new model
            dashboard.DisplayCars();
        }
    }
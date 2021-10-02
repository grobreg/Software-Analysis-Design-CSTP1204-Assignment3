using System;
using classes.Cars;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Forester() { brand = "Subaru", color = "Pearl", mileage = 28000, model = "Off-road", engineMake = "Asymmetrical", hasSunRoof = true};
            var car2 = new Cayenne() { brand = "Porsche", color = "Black", model = "Turbo", mileage = 12000, engine = "3.2L VR6", horsePower = 670 };
            var car3 = new Civic() { brand = "Honda", carShape = "Hatchback", color = "White", mileage = 6000, model = "Sport", type = "type R" };
            Car[] cars = { car1, car2, car3 };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}

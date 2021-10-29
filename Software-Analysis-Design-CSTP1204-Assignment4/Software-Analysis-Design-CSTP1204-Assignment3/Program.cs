using System;
using System.Collections.Generic;
using System.Text;


namespace Software_Analysis_Design_CSTP1204_Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Impreza() { Branding = "Subaru", Color = "Pearl", CurrMileage = 28000, Model = "Off-road", CurrFuel = 55 };
            var car2 = new Taycan() { Branding = "Porsche", Model = "Turbo", CurrMileage = 12000, CurrFuel = 92 };
            var car3 = new Civic() { Branding = "Honda", Color = "White", CurrMileage = 6000, Model = "Sport", Type = "type R", CurrFuel = 17 };
            var car4 = new Car(10) { Branding = "Generic", CurrMileage = 100, Model = "Default Sport", CurrFuel = 100 };
            Car[] cars = { car1, car2, car3, car4 };
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Years  == 0)
                {
                    cars[i].DisplayDashboardView();
                } else
                {
                    cars[i].DisplayDashboardView(cars[i].Years);
                }
            }
        }
    }
}

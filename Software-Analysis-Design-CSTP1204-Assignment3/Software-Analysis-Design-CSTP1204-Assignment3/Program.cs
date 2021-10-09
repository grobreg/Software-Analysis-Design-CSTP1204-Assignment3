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
            var car2 = new Taycan() { Branding = "Porsche", Color = "Black", Model = "Turbo", CurrMileage = 12000, CurrFuel = 92 };
            var car3 = new Civic() { Branding = "Honda", Color = "White", CurrMileage = 6000, Model = "Sport", Type = "type R", CurrFuel = 17 };
            Car[] cars = { car1, car2, car3 };
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].DisplayDashboardView();
            }
        }
    }
}

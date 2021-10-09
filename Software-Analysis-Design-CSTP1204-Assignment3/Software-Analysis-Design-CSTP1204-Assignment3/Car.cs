using System;
using System.Collections.Generic;
using System.Text;


namespace Software_Analysis_Design_CSTP1204_Assignment3
{
    public class Car
    {
        public string Branding;
        public string Model;
        public string Type;
        public string Color;
        public int CurrMileage;
        public int CurrFuel;

        private Dashboard Dashboard;

        public Car()
        {
            this.Dashboard = new Dashboard();
        }

        public DashboardModel GetDashboardModel()
        {
            FuelLevelEnum calculatedFuelSize = this.GetFuelSize();
            Dashboard.Mileage = CurrMileage;

            return new DashboardModel()
            {
                Mileage = Dashboard.Mileage,
                FuelSize = calculatedFuelSize
            };
        }

        public void DisplayDashboardView()
        {
            DashboardModel currentDashboard = this.GetDashboardModel();
            Console.WriteLine("--- My Car Dashboard --- \n\n {0} ---> {1} \n\n Mileage & Fuel Quantity: {2} ---> {3} kms\n\n", this.Branding, this.Model, currentDashboard.Mileage, currentDashboard.FuelSize);
        }

        private FuelLevelEnum GetFuelSize()
        {
            var fuelLevel = this.Dashboard.GetFuelSize(this.CurrFuel);

            if (fuelLevel <= 5)
                return FuelLevelEnum.Empty;
            else if (fuelLevel <= 15)
                return FuelLevelEnum.Low;
            else if (fuelLevel <= 35)
                return FuelLevelEnum.Quarter;
            else if (fuelLevel <= 55)
                return FuelLevelEnum.Half;
            else if (fuelLevel <= 80)
                return FuelLevelEnum.ThreeForths;
            else
                return FuelLevelEnum.Full;
        }
    }
}

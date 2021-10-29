using System;
using System.Collections.Generic;
using System.Text;

namespace Software_Analysis_Design_CSTP1204_Assignment3
{
    public class Dashboard
    {
        private int FuelSize;
        public int Mileage;

        public int GetFuelSize(int CurrFuel)
        {
            this.FuelSize = CurrFuel;
            return FuelSize;
        }
    }
}


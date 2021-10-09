using System;
using System.Collections.Generic;
using System.Text;

namespace Software_Analysis_Design_CSTP1204_Assignment3
{
    public class DashboardModel
    {
        public int Mileage;
        public FuelLevelEnum FuelSize;

        public DashboardModel()
        {
            FuelSize = FuelLevelEnum.Unknown;
        }
    }

    public enum FuelLevelEnum
    {
        Unknown,
        Empty,
        Low,
        Quarter,
        Half,
        ThreeForths,
        Full
    }

}

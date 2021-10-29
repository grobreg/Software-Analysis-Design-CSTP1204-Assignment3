using System;
using System.Collections.Generic;
using System.Text;

namespace Software_Analysis_Design_CSTP1204_Assignment3
{
    public class Porsche : Car
    {
        public string LuxuryFeature;
        protected string leatherSeats;


        public Porsche() : base()
        {
            this.Branding = "Porsche";
        }
    }

    public class Taycan : Porsche
    {
        public Taycan() : base()
        {
            this.leatherSeats = "red";
            this.Type = "Hybrid";
            this.Model = "ElectricTurbo4S";
            this.LuxuryFeature = "Premium Leather Electric Seats";
        }
    }
}

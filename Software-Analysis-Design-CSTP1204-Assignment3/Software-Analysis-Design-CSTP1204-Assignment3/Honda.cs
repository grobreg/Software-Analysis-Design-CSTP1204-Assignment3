using System;
using System.Collections.Generic;
using System.Text;

namespace Software_Analysis_Design_CSTP1204_Assignment3
{
    public class Honda : Car
    {
        public int EngineTorque;
        public bool RearSpoiler;
        public Honda() : base()
        {
            this.Branding = "Honda";
        }

    }

    public class Civic : Honda
    {
        public Civic() : base()
        {
            this.Type = "Sedan";
            this.Model = "Civic Type R";
            this.EngineTorque = 420;

        }
    }

}

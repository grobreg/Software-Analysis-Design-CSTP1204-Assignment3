using System;
using System.Collections.Generic;
using System.Text;

namespace Software_Analysis_Design_CSTP1204_Assignment3
{
    public class Subaru : Car
    {
        public string EngineMake;

        public Subaru() : base()
        {
            this.Branding = "Subaru";
        }
    }
    public class Impreza : Subaru
    {
        public Impreza() : base()
        {
            this.Model = "Sport";
            this.Type = "Hybrid";
            this.EngineMake = "Asymmetrical";
        }
    }

}

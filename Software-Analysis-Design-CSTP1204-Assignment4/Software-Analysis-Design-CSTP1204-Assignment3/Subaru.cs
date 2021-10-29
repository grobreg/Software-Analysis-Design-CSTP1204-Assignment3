using System;
using System.Collections.Generic;
using System.Text;

namespace Software_Analysis_Design_CSTP1204_Assignment3
{
    public class Subaru : Car
    {
        public string EngineMake;
        protected string EngineType;

        public Subaru() : base()
        {
            this.Branding = "Subaru";
            this.Color = "White";
        }
    }
    public class Impreza : Subaru
    {
        public Impreza() : base()
        {
            this.EngineType = "v8";
            this.Model = "Sport";
            this.Type = "Hybrid";
            this.EngineMake = "Asymmetrical";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinstonKoczkodajAssignment4
{
    public abstract class Planet
    {
        private double diameter;
        private double mass;
        private int moonCount;
        private string name;
        private double orbitalPeriod;
        private int ringCount;
        private double rotationPeriod;

        public double Diameter
        {
            get
            {
                return this.diameter;
            }
        }
        public double Mass
        {
            get
            {
                return this.mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return this.moonCount;
            }
            set
            {
                this.moonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this.orbitalPeriod;
            }
            set
            {
                this.orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this.ringCount;
            }
            set
            {
                this.ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this.rotationPeriod;
            }
            set
            {
                this.rotationPeriod = value;
            }
        }

        public Planet(string name, double diameter, double mass)
        {
            this.name = name;
            this.diameter = diameter;
            this.mass = mass;
        }
        public override string ToString()
        {
            string outputstring = "";
            outputstring += "Name: " + name + " Diameter: " + diameter + " Mass: " + mass;

            return outputstring;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinstonKoczkodajAssignment4
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string type;
        private bool hasMoons;
        private bool hasRings;

        public bool HasMoons
        {
            get
            {
                if (MoonCount > 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                this.hasMoons = value;
            }
        }

        public bool HasRings
        {
            get
            {
                if (RingCount > 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                this.hasRings = value;
            }
        }

        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            if (type == "Gas" || type == "Ice")
            {
                this.type = type;
            }
            else {
                this.type = "Giant planets must be either type Gas or Ice";
            }
            
        }

        /*
        Testing if type was correct:

        public override string ToString()
        {
            string outputstring = "";
            outputstring += "Type: " + type;

            return outputstring;
        }*/
    }
}

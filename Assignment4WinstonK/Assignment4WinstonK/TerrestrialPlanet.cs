using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinstonKoczkodajAssignment4
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        private bool oxygen;
        private bool hasMoons;

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

        public bool Habitable {
            get {
                if (oxygen == true)
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
                this.oxygen = value;
            }
        }

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this.oxygen = oxygen;
        }
    }
}

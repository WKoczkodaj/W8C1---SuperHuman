using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W8C1
{
    public class SuperHero : Human, IHasKarma
    {
        private int karma;

        public int Karma {
            get
            {
                return this.karma;
            }
            set
            {
                this.karma = value;
            }
        }

        public SuperHero(string name) : base(name)
        {
            
        }
        
        // Must have because of parent class
        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented");
        }
    }
}
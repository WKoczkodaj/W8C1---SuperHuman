using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W8C1
{
    public class SuperHero : SuperHuman, IHasKarma
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

        public SuperHero(string name, int karma) : base(name)
        {
            this.Karma = karma;
        }
    }
}
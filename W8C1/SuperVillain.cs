using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W8C1
{
    public class SuperVillain : SuperHuman, IHasMalice
    {
        private int malice;
        public int Malice
        {
            get
            {
                return this.malice;
            }
            set
            {
                this.malice = value;
            }
        }
            public SuperVillain(string name, int malice) : base(name)
        {
            this.Malice = malice;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W8C1
{
    // Creation of power datatype
    public class Power
    {
        public string Name { get; set; }
        public int Rank { get; set; }

        public Power(string name, int rank) {
            this.Name = name;
            this.Rank = rank;
        }
    }
}
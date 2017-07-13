using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W8C1
{
    public class SuperHuman : Human
    {
        private List<Power> powers;

        public List<Power> Powers {
            get
            {
                return this.powers;
            }
        }


        public SuperHuman(string name) : base(name)
        {
            this.Initialize();
        }


        private void Initialize()
        {
            this.powers = new List<Power>();
        }

        public void AddPower(string name, int rank)
        {
           this.Powers.Add(new Power(name, rank));
        }
        /*
        public void DisplayPowers()
        {
            foreach (var i in Powers)
            {
                Console.WriteLine("Power: " + i.Name + "\tRank: " + i.Rank);
            }
        }
        */

        public override string ToString()
        {
            string outputstring = "";
            outputstring += "****************\n" + "Name: " + Name;

            foreach (var i in Powers)
            {
                outputstring += (" Power: " + i.Name + "\tRank: " + i.Rank + "\n");
            }

            outputstring += "****************\n";
            return outputstring;

        }

        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented");
        }
    }
}
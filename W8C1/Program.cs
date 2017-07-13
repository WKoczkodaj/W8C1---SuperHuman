using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Winston Koczkodaj 
 * Date: 7/11/17
 */
namespace W8C1
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superhero = new SuperHero("SuperDude", 5);
            superhero.Powers.Add(new Power("Electricity Manipulation", 6));
            //superhuman.DisplayPowers();

            Console.WriteLine(superhero.ToString());
            Console.WriteLine("Karma: " + superhero.Karma + "\n\n");


            SuperVillain supervillain = new SuperVillain("EvilGuy", 6);
            supervillain.Powers.Add(new Power("Black Hole Creation",9));
            supervillain.Powers.Add(new Power("Burger Creation", 1));
            supervillain.Powers.Add(new Power("Teleportation", 5));

            Console.WriteLine(supervillain.ToString());
            Console.WriteLine("Malice: " + supervillain.Malice);
        }
    }
}

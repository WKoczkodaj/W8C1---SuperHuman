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
            SuperHero superhuman = new SuperHero("SuperDude", 5);
            superhuman.Powers.Add(new Power("Electricity Manipulation", 6));
            //superhuman.DisplayPowers();

            Console.WriteLine(superhuman.ToString());
            Console.WriteLine("Karma: " + superhuman.Karma);
        }
    }
}

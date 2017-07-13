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
            SuperHuman superhuman = new SuperHuman("SuperDude");
            superhuman.AddPower("Electricity Manipulation", 6);
            //superhuman.DisplayPowers();

            Console.WriteLine(superhuman.ToString());
        }
    }
}

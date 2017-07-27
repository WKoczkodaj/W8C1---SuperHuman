using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Header:
   Author: Winston Koczkodaj 
   Student#: 300895095
   Date Last Modified: 7/27/17
   Program Description: Create Planets using their Name, Diameter, Mass, and other properties.
   Revision History: ?
*/
namespace WinstonKoczkodajAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet gplanet = new GiantPlanet("Dark Planet X",55,600.33, "Gas");
            Console.WriteLine(gplanet.ToString());
            

            TerrestrialPlanet tplanet = new TerrestrialPlanet("Earicus", 23, 100.33, true);
            Console.WriteLine(tplanet.ToString());

            WaitForAnyKey();
        }
        static void WaitForAnyKey() {
            Console.ReadKey();
        }
    }
}

/*Created by :AnsonBaby
 * Lastmodified: 27th Jan 2015
 * Program description: Program entry point 
 * Revision History: 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_Comp123
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero superMan = new Hero("superMan");//new object
            superMan.show();// call the show method to display the abilities
            superMan.fight();// call the fight method from the hero class
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();//wait for an entry to exit 

        }
    }
}

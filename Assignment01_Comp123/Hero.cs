/*Created by :AnsonBaby
 * Lastmodified: 27th Jan 2015
 * Program description: Hero class implimentation 
 * Revision History: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_Comp123
{
    class Hero
    {
        //Private Properties++++++++++++++++++++++++++++++++++
        private int strength;
        private int speed;
        private int health;


        //Public Properties+++++++++++++++++++++++++++++++++
        public string name;
        public Random rnd = new Random();

        // Constructor Method
        public Hero(string name)
        {
            this.name = name;
            generateAbilities();
        }

        // Private Methods+++++++++++++++++++++++++++++++++++
        // generating hero abilities random number between 1 and 100
        private void generateAbilities()
        {
            strength = rnd.Next(1, 100);
            speed = rnd.Next(1, 100);
            health = rnd.Next(1, 100);
        }
        //checks hit attempt of 20 % hit chance
        private bool hitAttempt()
        {
            return (rnd.Next(1, 5) == 1);
        }
        // Hit damage is hero's strength multipied with random number between 1 and 6
        private int hitDamage()
        {
            return (strength * rnd.Next(1, 6));
        }
        

        // Public Methods+++++++++++++++++++++++++++++++++++++++++++++

        public void fight()
        {

            if (hitAttempt() == true)
            {
                int damage = hitDamage();
                Console.WriteLine("Hit damage is {0}", damage);
            }
            else
            {
                Console.WriteLine("No hit");
            }
        }

        public void show()
        {
            Console.WriteLine("Strength is {0}", strength);
            Console.WriteLine("Speed is {0}", speed);
            Console.WriteLine("Health is {0}", health);

        }

        
    }
}

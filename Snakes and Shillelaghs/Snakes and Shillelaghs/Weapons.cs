using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes_and_Shillelaghs
{
    class Weapons //class #3
    {
        //used to hold properties for the weapons
        public string name;
        public string color;
        public int damage;

        public void Declarations(string nameVal, string colorVal, int damageVal) //method to declare properties of weapons. 3 parameters: name, color, and damage
        {
            this.name = nameVal;
            this.color = colorVal;
            this.damage = damageVal;
        }

    }
}
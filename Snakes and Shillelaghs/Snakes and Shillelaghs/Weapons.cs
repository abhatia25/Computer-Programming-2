using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes_and_Shillelaghs
{
    class Weapons
    {
        public string name;
        public string color;
        public int damage;

        public void Declarations(string nameVal, string colorVal, int damageVal)
        {
            this.name = nameVal;
            this.color = colorVal;
            this.damage = damageVal;
        }

    }
}
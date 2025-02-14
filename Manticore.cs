// Written By Chloe Jensrud
// 2/11/25


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manticore
{
    public class Manticore
    {
        private int distance = -1;
        private int health = -1;

        public int Distance 
        {   get { return distance; } set { distance = value; } 
        }
        public int Health
        {
            get { return health; } set { health = value; }
        }

        public Manticore(int distance)
        { this.distance = distance; }

        public void TakeDamake(int damage)
        {
            this.health -= damage;
            if (this.health < 0)
            {
                this.health = 0;
            }
        }

    }
}

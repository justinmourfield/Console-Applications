using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    class Humvee:Vehicles
    {
        //constructors
        public Humvee()
        {

        }
        //method

        public void EngageEnemy()
        {
            Console.WriteLine("The machine gunner pans the crows nest to face the threat and unleashes the " +
                ".50 cal in the direction of the threat.");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    class Tank:Vehicles
    {
        //constructors
        public Tank()
        {

        }
        //method


        public override void stop()
        {
            Console.WriteLine("The tracks stopped turning.");
        }


        public void EngageEnemy()
        {
            Console.WriteLine("The turret turns and blasts a round down range decimating all threats.");
        }
    }
}

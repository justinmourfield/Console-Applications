using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    class Rocket_Launcher:Weapons
    {
        //constructors
        public Rocket_Launcher()
        {

        }
        //method
        public override void load()
        {
            Console.WriteLine("The rocket Launcher is being loaded .");
        }

        public override void fire()
        {
            Console.WriteLine("Backblast area clear?! Fire!!!");
        }
    }
}

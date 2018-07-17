using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    class Weapons
    {
        //constructors
        public Weapons()
        {

        }
        //method
        public virtual void load()
        {
            Console.WriteLine("The weapon is being loaded.");
        }

        public virtual void fire()
        {
            Console.WriteLine("The weapon is being fired.");
        }
    }
}

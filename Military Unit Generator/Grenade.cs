using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
     class  Grenade : Weapons
    {
        //constructors
        public Grenade()
        {

        }
        //method 
        public void prepGrenade(string name)
        {
            Console.WriteLine($"{name} is prepping a grenade to be used. Thumb to clip, twist pull pin, and throw.");
        }

        public void ThrowGrenade(string name)
            {
            Console.WriteLine($"{name} threw a grenade.");
            Console.WriteLine("BOOOOM!!!!!!!!");
            }
        

    }
}

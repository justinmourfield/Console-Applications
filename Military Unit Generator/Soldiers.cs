using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Military
{
    class Soldiers
    {
        //Constuctors
        public Soldiers()
        {
            Console.WriteLine("You have a new soldier");
        }


            //methods
        public virtual void GetPromoted(int OldRank, string Name)
        {
            Console.WriteLine("Congratulations on being promoted.");

        }

        public void DoPT(string name)
        {
            Console.WriteLine($"{name} is doing PT.");
        }

        public void StopPT(string name)
        {
            Console.WriteLine($"{name} stopped doing PT.");
        }
        public virtual void Attack(string name)
        {
            Console.WriteLine($"{name} is attacking.");
            Grenade nade = new Grenade();
            nade.prepGrenade(name);
           nade.ThrowGrenade(name);
            
        }

    }
}

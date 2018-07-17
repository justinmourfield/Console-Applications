using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    class Vehicles
    {
        //constructors
        public Vehicles()
        {

        }
        //method
        public void start()
        {
            Console.WriteLine("The engine is starting.");
        }

        public virtual void drive()
        {
            Console.WriteLine("The vehicle is moving.");
        }

        public virtual void stop()
        {
            Console.WriteLine("You are braking and the tires slowed down.");
        }


        public void Turnoff()
        {
            Console.WriteLine("The engine is powering down.");
        }
    }
}

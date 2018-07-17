using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roullette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The wheel is spinning.");
            Wheel newspin = new Wheel();
            newspin.getnumber();
            Console.WriteLine("The spin is complete.");
            
            


        }
    }
}


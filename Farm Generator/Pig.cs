using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarm
{
    class Pig : Animal
    {
       
        //Fields
        private string animalName { get; set; }

        //constructors
        public Pig()   //Default Consturctor
        {
            Console.WriteLine("You created a pig!");
        }
        public Pig(String name)
        {
            animalName = name;
            Console.WriteLine($"You created a pig named {animalName}!");
        }
        
        //methods
        public override void Eat()
        {
            Console.WriteLine($"{animalName} is eating slop.");
            
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{animalName} is oinking.");
        }

        public void Root()
        {
            Console.WriteLine($"{animalName} is rooting in the mud.");
        }
        
    }
}

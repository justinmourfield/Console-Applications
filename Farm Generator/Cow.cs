using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarm
{
    class Cow : Animal
    {
        //Fields
        private string animalName { get; set; }

        //constructors
        public Cow()   //Default Consturctor
        {

        }

        public Cow(String name)
        {
            animalName = name;
            Console.WriteLine($"You created a cow! Its name is {animalName}. ");
        }
        //methods
        
        public override void Eat()
        {
            Console.WriteLine($"{animalName} is eating grass.");
        }
        
        public override void MakeNoise()
        {
            Console.WriteLine($"{animalName} is mooing.");
        }

        public void produceMilk()
        {
            Console.WriteLine($"{animalName} is being milked.");
        }
    }
}

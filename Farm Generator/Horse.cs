using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace MyFarm
{
    class Horse : Animal
    {
//-----------------Fields
        private string animalName { get; set; }

//--------------constructors
        public Horse()   //Default Constructor
        {

        }

        public Horse(String name)
        {
            animalName = name;
            Console.WriteLine($"You created a horse! Its name is {animalName}. ");
        }

//-----------------methods
        
         public override void Eat()
         {
            Console.WriteLine($"{animalName} is eating carrots.");
        }
         
         public override void MakeNoise()
         {
            Console.WriteLine($"{animalName} is neighing.");
        }

         public void Gallop()
         {
            Console.WriteLine($"{animalName} is eating galloping through the fields.");
        }
    }
}

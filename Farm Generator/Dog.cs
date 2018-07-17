using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarm
{
    class Dog:Animal
    {
        //Fields
        private string animalName { get; set; }
        
        //constructors Dog Class inherits default constructor from Animal Class

        public Dog(String name) // Creates a dog that is named
        {
            animalName = name;
            Console.WriteLine($"You created a dog! Its name is {animalName}. ");
        }


        //methods
        public override void Eat() 
        {
            Console.WriteLine($"{animalName} is eating kibble.");
        }
        
        public override void Move(string name) // Dog will move. 
        {
            Console.WriteLine($"{animalName} is running through the yard and herding the other animals.");
        }

       public override void MakeNoise() // Dog will bark
        {
            Console.WriteLine($"{animalName} is barking.");
        }
       
       public void  Fetch() // Dog will play fetch
        {
            Console.WriteLine($"{animalName} is playing fetch with you.");
        }
    }
}

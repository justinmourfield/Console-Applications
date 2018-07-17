using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarm
{
    class Animal
    {
        //Fields
        private int count = 0;//count created so that once future objects are instantiated, the count can keep track of how many are created.
        private string animalName { get;  set; }
        //constructors

        public Animal ()//default constructor all classes inherit this base class implementation
        {
            
        }

        //methods that all animals can invoke 
        
       public virtual void Eat()//Animal will eat. What the animal eats is overriden in derived classes 
        {
           Console.WriteLine("The animal is eating.");
        }
        
        public virtual void MakeNoise()// Animal will make noise. The noise overridden in derived classes for specific type of animal 
        {
            Console.WriteLine("The animal is making noise.");
        }

        public virtual void Move(string name)// Animal will move. Animal movement is overridden in derived classes for specific type of animal 
        {
            animalName = name;
            Console.WriteLine($"The {animalName} is walking.");
        }

        public static void Party() // Invoke this method and use your imagination
        {
        Console.WriteLine("Congratulations... You've really done it now! You have a farm full of PARTY ANIMALS!!!");
        }
       
        
    }
}


            
            
            
            
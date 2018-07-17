using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarm
{
    class Program
    {

        public static string animalName;//Field variable to allow the user defined animal name to be used throughout the Program class

        static void Main()
        {
            try
            {
                Console.WriteLine("Hello! Welcome to your own personal farm generator.");
                Console.WriteLine("");
                Console.WriteLine("You can use this program to make your own farm.");
                Console.WriteLine("First create your farm animals. You can make a pig, dog, cow, or horse.");
                ChooseAnimal();
            }
            catch (EntryPointNotFoundException EntryNotFound)
            {
                Console.WriteLine(EntryNotFound.Message);
            }
            catch (NotImplementedException NotImplem)
            {
                Console.WriteLine(NotImplem.Message);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message);}
        }
        private static void ChooseAnimal()
        {
            try
            {
                Console.WriteLine("Enter '1' to create a pig, '2' for dog, '3' for cow, '4' for horse or '5' to exit the program.");
                int typeofAnimal = int.Parse(Console.ReadLine());
                InstantiateAnimal(typeofAnimal);
            }
            catch(FormatException Fex)
            { Console.WriteLine(Fex.Message); }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }

        private static void InstantiateAnimal(int createAnimal)
        {
            try
            {
                switch (createAnimal)
                {
                    case 1:
                        makePig();
                        break;
                    case 2:
                        makeDog();
                        break;
                    case 3:
                        makeCow();
                        break;
                    case 4:
                        makeHorse();
                        break;
                    case 5:
                        exit();
                        break;
                    default:
                        Console.WriteLine("Im sorry but that wasnt a valid option.");
                        break;
                }
            }
            catch (Exception Fex)
            { Console.WriteLine(Fex.Message); }
            
        }
        private static void makePig()
        {
         try {
                Console.WriteLine("What do you want to name your pig?");
                animalName = Console.ReadLine();//User names animal
                Pig pig1 = new Pig(animalName);//Pig object is created and the user defined name is transfered to be used by the Pig class
                Console.WriteLine("Each animal can do things. Some things every animal can do are eat, make noise, and move.");
                Console.WriteLine("However, only pigs can root in the mud.");
                Console.WriteLine($"What do you {animalName} to do? Enter '1' to eat, '2' to make noise, '3' to move, '4' to root, and '5' to have a good time");
                int action = int.Parse(Console.ReadLine());//gets value for switch statement to run a specific method
                switch (action)//implements methods applicable to specific animal
                {
                    case 1:
                        pig1.Eat();
                        break;
                    case 2:
                        pig1.MakeNoise();
                        break;
                    case 3:
                        pig1.Move(animalName);
                        break;
                    case 4:
                        pig1.Root();
                        break;
                    case 5:
                        Animal.Party();
                        break;
                    default:
                        Console.WriteLine("Sorry, that wasn't a valid action to choose from.");
                        break;
                }
                ChooseAnimal();//allows user to reselect another animal to create
            }
            catch (FormatException Fex)
            { Console.WriteLine(Fex.Message); }
            catch(DuplicateWaitObjectException Dex)
            { Console.WriteLine(Dex.Message); }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
        private static void makeDog()
        {
            try
            {
                Console.WriteLine("What do you want to name your dog?");
                animalName = Console.ReadLine();//User names animal
                Dog dog1 = new Dog(animalName);//Dog object is created and the user defined name is transfered to be used by the dog class           
                Console.WriteLine("Each animal can do things. Some things every animal can do are eat, make noise, and move.");
                Console.WriteLine("However, only dogs can play fetch.");
                Console.WriteLine($"What do you want {animalName} to do? Enter '1' to eat, '2' to make noise, '3' to move, '4' to play fetch, and '5' to have a good time");
                int action = int.Parse(Console.ReadLine());//gets value for switch statement to run a specific method
                switch (action)//implements methods applicable to specific animal
                {
                    case 1:
                        dog1.Eat();
                        break;
                    case 2:
                        dog1.MakeNoise();
                        break;
                    case 3:
                        dog1.Move(animalName);
                        break;
                    case 4:
                        dog1.Fetch();
                        break;
                    case 5:
                        Animal.Party();
                        break;
                    default:
                        Console.WriteLine("Sorry, that wasn't a valid action to choose from.");
                        break;
                }
                ChooseAnimal();//allows user to reselect another animal to create
            }
            catch (FormatException Fex)
            { Console.WriteLine(Fex.Message); }
            catch (DuplicateWaitObjectException Dex)
            { Console.WriteLine(Dex.Message); }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
        private static void makeCow()
        {
            try
            {
                Console.WriteLine("What do you want to name your cow?");
                animalName = Console.ReadLine();//User names animal
                Cow cow1 = new Cow(animalName);//cow object is created and the user defined name is transfered to be used by the cow class           
                Console.WriteLine("Each animal can do things. Some things every animal can do are eat, make noise, and move.");
                Console.WriteLine("However, only cows can produce milk.");
                Console.WriteLine($"What do you want {animalName} to do? Enter '1' to eat, '2' to make noise, '3' to move, '4' to produce milk, and '5' to have a good time");
                int action = int.Parse(Console.ReadLine());//gets value for switch statement to run a specific method
                switch (action)//implements methods applicable to specific animal
                {
                    case 1:
                        cow1.Eat();
                        break;
                    case 2:
                        cow1.MakeNoise();
                        break;
                    case 3:
                        cow1.Move(animalName);
                        break;
                    case 4:
                        cow1.produceMilk();
                        break;
                    case 5:
                        Animal.Party();
                        break;
                    default:
                        Console.WriteLine("Sorry, that wasn't a valid action to choose from.");
                        break;
                }
                ChooseAnimal();//allows user to reselect another animal to create
            }
            catch (FormatException Fex)
            { Console.WriteLine(Fex.Message); }
            catch (DuplicateWaitObjectException Dex)
            { Console.WriteLine(Dex.Message); }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
        private static void makeHorse()
        {
            try
            {
                Console.WriteLine("What do you want to name your horse?");
                animalName = Console.ReadLine();//User names animal
                Horse horse1 = new Horse(animalName);//Horse object is created and the user defined name is transfered to be used by the horse class           
                Console.WriteLine("Each animal can do things. Some things every animal can do are eat, make noise, and move.");
                Console.WriteLine("However, only horses can gallop.");
                Console.WriteLine($"What do you want {animalName} to do? Enter '1' to  eat, '2' to make noise, '3' to move, '4' to gallop, and '5' to have a good time");
                int action = int.Parse(Console.ReadLine());//gets value for switch statement to run a specific method
                switch (action)//implements methods applicable to specific animal
                {
                    case 1:
                        horse1.Eat();
                        break;
                    case 2:
                        horse1.MakeNoise();
                        break;
                    case 3:
                        horse1.Move(animalName);
                        break;
                    case 4:
                        horse1.Gallop();
                        break;
                    case 5:
                        Animal.Party();
                        break;
                    default:
                        Console.WriteLine("Sorry, that wasn't a valid action to choose from.");
                        break;
                }
                ChooseAnimal();//allows user to reselect another animal to create 
            }
            catch (FormatException Fex)
            { Console.WriteLine(Fex.Message); }
            catch (DuplicateWaitObjectException Dex)
            { Console.WriteLine(Dex.Message); }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
        private static void exit()
        {
            Console.WriteLine("Thanks for creating a farm! See you next time you party animal!");
        }


    }
}

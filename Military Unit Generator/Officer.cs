using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    class Officer:Soldiers
    {
        // Constructors
        
        public Officer()
        {

        }
        
        public Officer(string name)
        {
            Console.WriteLine($"Nice to meet you {name}. Welcome to the unit.");
        }


        //Methods
        public override void GetPromoted(int OldRank, string Name)
        {
            string[] EnlistedRanks = new string[10] { "1LT", "2LT", "CPT", "MAJ", "LTC", "COL", "BG", "MG", "LG", "GEN" };


            int i = OldRank-1;
            i++;
            string Rank;
            Rank = EnlistedRanks[i];

           Console.WriteLine($"Congratulations {Name} for being promoted to {Rank}");
            
        }
        public void drinkCoffee(string name)
        {
            Console.WriteLine($"{name} is drinking the coffee that was made.");
        }
        public override void Attack(string name)
        {
            Console.WriteLine($"{name} is grabbing a rocket launcher.");
            Rocket_Launcher rpg = new Rocket_Launcher();
            rpg.load();
                rpg.fire();
            
        }
    }
}

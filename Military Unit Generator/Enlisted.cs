using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    class Enlisted:Soldiers
    {
        //Constructors
        public Enlisted()
        {
            
        }


        //Methods
        public override void GetPromoted(int OldRank, string Name)
        {
            string[] EnlistedRanks = new string[9] { "PVT", "PV2", "PFC", "SPC", "SGT", "SSG", "SFC", "MSG", "SGM", };


            int i = OldRank;
            string Rank;
            Rank = EnlistedRanks[i] + 1;

            if (Rank == EnlistedRanks[5])
            {
                Console.WriteLine($"Congratulations {Name}, for being promoted to an NCO. Now go memorize your TLPs!");
            }
            else if (Rank != EnlistedRanks[5])
            {
                Console.WriteLine($"Congratulations {Name} for being promoted to {EnlistedRanks[i]}");
            }
        }

            public void makeCoffee(string name)
            {
                Console.WriteLine($"{name} is making a wicked pot of coffee.");
            }

        }
    }


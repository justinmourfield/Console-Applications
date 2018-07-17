using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military
{
    class Program
    {
       static string name;
        static int rank;
        static void Main(string[] args)
        {
            CreateEnlistedSoldier();
            Console.WriteLine("");
            CreateOfficer();
            Console.WriteLine("");
            CreateHumvee();
            Console.WriteLine("");
            CreateTank();

        }

        private static void CreateEnlistedSoldier()
        {
            Enlisted JoeSnuffy = new Enlisted();
            name = "Snuffy";
            rank = 4;           
            JoeSnuffy.Attack(name);
            JoeSnuffy.GetPromoted(3, name);
            JoeSnuffy.makeCoffee(name);
        }

        private static void CreateOfficer()
        {
            name = "Rambo";
            rank = 2;
            Officer Rambo = new Officer(name);
            Rambo.GetPromoted(rank, "Rambo");
            Rambo.drinkCoffee(name);
            Rambo.Attack("Rambo");
        }
        private static void CreateTank()
        {
            Tank abrahams = new Tank();
            abrahams.start();
            abrahams.drive();
            abrahams.stop();
            abrahams.EngageEnemy();
            abrahams.drive();
            abrahams.Turnoff();

        }
        private static void CreateHumvee()
        {
            Humvee Hummer = new Humvee();
            Hummer.start();
            Hummer.drive();
            Hummer.stop();
            Hummer.EngageEnemy();
            Hummer.drive();
            Hummer.Turnoff();
        }
    }
}

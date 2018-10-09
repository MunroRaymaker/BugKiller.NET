using System;
using Bugkiller.Implementation;

namespace Bugkiller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test bench for NUnit tests");
            Console.WriteLine("======================");
            
            string input = "";

            do
            {
                Console.WriteLine();

                Console.WriteLine("Press x to shoot at bug");
                Console.WriteLine();
                Console.WriteLine("Press q to quit");
                Console.Write("Enter choice: ");

                input = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("======================");

                if (input == "x") Shoot();

                Console.WriteLine("======================");
            } while (input != "q");
        }

        private static void Shoot()
        {
            var bug = new Bug();
            var gun = new Raygun();

            gun.FireAt(bug);
            
            Console.WriteLine("Bug is " + (bug.IsDead() ? "dead" : "alive"));
            Console.WriteLine("Raygun has ammo: " + gun.HasAmmo());
        }
    }
}

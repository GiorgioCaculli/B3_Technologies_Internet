using System;
using System.Collections.Generic;

namespace EInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EInitializers");

            Town townMons = new Town
            {
                Name = "Mons",
                Houses = new List<House>()
                {
                    new House
                    {
                        Number = 10,
                        Street = "Rue de la Victoire"
                    },
                    new House
                    {
                        Number = 15,
                        Street = "Rue de la Chance"
                    }
                }
            };
            
            Console.WriteLine(townMons);
        }
    }
}
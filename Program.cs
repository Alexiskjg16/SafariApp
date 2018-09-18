using System;
using SafariApp.Models;

namespace SafariApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Animals Did You See Today?");
            var species = Console.ReadLine();
            
            var newAnimal = new SeenAnimals{ Species = species };

            var db = new Safari_VacationContext();

            db.SeenAnimalsTable.Add(newAnimal);
            db.SaveChanges();

            var AllAnimals = db.SeenAnimalsTable;

            foreach (var animal in AllAnimals)
            {
                System.Console.WriteLine(value: $"AllAnimals:{animal.Species}");
            } 
        }
    }
}

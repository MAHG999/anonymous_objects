using System;
using System.Collections.Generic;
using System.Linq;

namespace anobymus_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Firts example
            var beer = new { Name = "Heineken", Style = "Porter" };
            Console.WriteLine(beer.Name);
            //secont example
            List<Beer> beers = new List<Beer>()
            {
                new Beer() { Name = "Tecate", Style = "Porter" },
                new Beer() { Name = "Honey Dew", Style = "Golden Ale" }
            };

            var nameBeers = from d in beers
                            select new {Name1 = d.Name};
            nameBeers.ToList().ForEach(d => Console.WriteLine(d.Name1));
        }

        public class Beer
        {
            public string Name { get; set; }
            public string Style { get; set; }
        }
    }
}

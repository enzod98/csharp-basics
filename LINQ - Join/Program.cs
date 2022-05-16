using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ___Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var beers = new List<Beer>()
            {
                new Beer(){ Name="Pilsen", Country="Paraguay" },
                new Beer(){ Name="Corona", Country="México" },
                new Beer(){ Name="Dellirium", Country="Bélgica" },
                new Beer(){ Name="Quilmes", Country="Argentina" },
                new Beer(){ Name="Erdinger", Country="Alemania" }
            };

            var countries = new List<Country>()
            {
                new Country(){ Name="Paraguay", Continente="América" },
                new Country(){ Name="México", Continente="América" },
                new Country(){ Name="Bélgica", Continente="Europa" },
                new Country(){ Name="Argentina", Continente="América" },
                new Country(){ Name="Alemania", Continente="Europa" }
            };

            var beersWithContinent = from beer in beers
                                     join country in countries
                                     on beer.Country equals country.Name
                                     select new
                                     {
                                         Name = beer.Name,
                                         Country = beer.Country,
                                         Continent = country.Continente
                                     };

            foreach(var b in beersWithContinent)
                Console.WriteLine($"Cerveza: {b.Name}, Pais: {b.Country}, Continente: {b.Continent}");
        }
    }

    public class Beer
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }

    public class Country
    {
        public string Name { get; set; }
        public string Continente { get; set; }
    }
}

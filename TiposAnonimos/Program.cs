using System;

namespace TiposAnonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Los objetos anónimos son Read Only
            var enzo = new
            {
                Name = "Enzo",
                Country = "Paraguay"
            };

            Console.WriteLine($"{enzo.Name} de { enzo.Country }");

            //La colección de objetos anónimos deben tener los mismos atributos
            var beers = new[]
            {
                new { Name="Red", Brand="Pilsen"},
                new { Name="London", Brand="Quilmes"}
            };

            foreach(var beer in beers)
            {
                Console.WriteLine(beer.Name);
            }
        }
    }
}

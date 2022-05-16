using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Beer> cervezas = new List<Beer>()
            {
                new Beer()
                {
                    Name = "Pilsen",
                    Country = "Paraguay"
                },
                new Beer()
                {
                    Name = "Quilmes",
                    Country = "Argentina"
                },
                new Beer()
                {
                    Name = "Delirium",
                    Country = "Bélgica"
                }
            };

            foreach (var cerveza in cervezas)
                Console.WriteLine(cerveza.ToString());

            Console.WriteLine("------------");

            //select 
            var beersName = from cerveza in cervezas
                            select new { Name = cerveza.Name, CantidadLetras = cerveza.Name.Length };

            foreach(var names in beersName)
                Console.WriteLine($"{names.Name}, cantidad de letras: {names.CantidadLetras}");

            Console.WriteLine("------------");

            var beersNameReal = from b in beersName
                                select new
                                {
                                    Name = b.Name
                                };

            foreach (var names in beersNameReal)
                Console.WriteLine($"{names.Name}");

            Console.WriteLine("------------");

            var beersParaguay = from cerveza in cervezas
                                where cerveza.Country == "Paraguay"
                                //|| cerveza.Country == "Argentina"
                                select cerveza;

            foreach(var cerveza in beersParaguay)
                Console.WriteLine(cerveza);

            Console.WriteLine("------------");

            var cervezasOrdenadas = from cerveza in cervezas
                                    orderby cerveza.Country //descending
                                    select cerveza;

            foreach (var cerveza in cervezasOrdenadas)
                Console.WriteLine(cerveza);
        }
    }

    public class Beer
    {
        public string Name { get; set; }    
        public string Country { get; set; }
        public override string ToString()
        {
            return $"Nombre: {Name}, País: {Country}"; 
        }
    }
}

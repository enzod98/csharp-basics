using System;

namespace Tuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Son básicamente arreglos de variables de distintos tipos
            //Similar a objetos anónimos pero son editables luego de declararse 
            (int id, string name) product = (1, "pepsi cola");
            Console.WriteLine(product.id + " " + product.name);

            product.name = "Pepsi Cero";
            Console.WriteLine(product.id + " " + product.name);

            var person = ("enzo", 23);
            Console.WriteLine($"Persona: { person.Item1 }, edad: { person.Item2 }");

            //En un arreglo, las tuplas deben tener la misma estructura
            var people = new[]
            {
                (1, "Enzo"),
                (2, "John"),
                (3, "Sosa")
            };
            Console.WriteLine("--LISTA--");
            foreach(var p in people)
            {
                Console.WriteLine($"Persona: { p.Item2 }, id: { p.Item1 }");
            }

            (int id, string name)[] people2 = new[]
            {
                (1, "Enzo"),
                (2, "John"),
                (3, "Sosa")
            };

            Console.WriteLine("--LISTA 2--");
            foreach (var person2 in people2)
            {
                Console.WriteLine($"Persona: { person2.name }, id: { person2.id }");
            }

            //Muy útil cuando queremos hacer una función que devuelva más de un valor
            var cityInfo = GetCiudad();
            Console.WriteLine(cityInfo.lat);
            Console.WriteLine(cityInfo.lng);
            Console.WriteLine(cityInfo.name);

            //Para ignorar ciertos valores que nos devuelve una función, sólo ponemos un _ en el lugar que corresponda
            var (_, lng, _) = GetCiudad();
            Console.WriteLine(lng);
        }

        public static (float lat, float lng, string name) GetCiudad()
        {
            float lat = 12.125f;
            float lng = 12.125f;
            string name = "Roque";

            return (lat, lng, name);
        }
    }
}

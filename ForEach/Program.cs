using System;
using System.Collections.Generic;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                23,45,78,8,5,4,1
            };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            List<Persona> personas = new List<Persona>()
            {
                new Persona(){ Name= "Hector", Country="México"},
                new Persona(){ Name= "Enzo", Country="Paraguay"},
                new Persona(){ Name= "Fernando", Country="El Salvador"}
            };

            Show(personas);
            personas.RemoveAt(0);
            Show(personas);

        }

        static void Show(List<Persona> estudiantes)
        {
            Console.WriteLine("-- PERSONAS --");
            foreach(var persona in estudiantes)
            {
                Console.WriteLine($"Nombre: { persona.Name }, país: { persona.Country }");
            }
        }
    }

    public class Persona
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}

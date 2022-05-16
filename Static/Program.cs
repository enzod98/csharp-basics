using System;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona()
            {
                Nombre = "Enzo",
                Edad = 23
            };
            Persona persona2 = new Persona()
            {
                Nombre = "Juan",
                Edad = 30
            };
            Console.WriteLine(Persona.GetCount());
        }
    }

    public static class A
    {
        //Cuando una clase es estática, todos sus métodos y atributos lo deben ser también
        public static void Some()
        {
            Console.WriteLine("Algo");
        }
    }

    public class Persona
    {
        public static int Count = 0;
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Persona()
        {
            Count++;
        }

        public static string GetCount()
        {
            return $"Esta clase se ha instanciado { Count } veces";
        }
    }
}

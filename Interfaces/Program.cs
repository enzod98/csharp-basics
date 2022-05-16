using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiburon[] tiburones = new Tiburon[]
            {
                new Tiburon("Martillo", 58),
                new Tiburon("Blanco", 65)
            };

            IPescado[] pescados = new IPescado[]
            {
                new Sirena(58),
                new Sirena(65),
                new Tiburon("Puñal", 65)
            };

            mostrarPescados(tiburones);
            mostrarAnimales(tiburones);
            mostrarPescados(pescados);
        }
        public static void mostrarPescados(IPescado[] pescado)
        {
            Console.WriteLine("--MOSTRAMOS LOS PECES--" + Environment.NewLine);
            for(int i = 0; i < pescado.Length; i++)
            {
                Console.WriteLine(pescado[i].Nadar());
            }
        }

        public static void mostrarAnimales(IAnimal[] animal)
        {
            Console.WriteLine("--MOSTRAMOS LOS ANIMALES--" + Environment.NewLine);
            for (int i = 0; i < animal.Length; i++)
            {
                Console.WriteLine(animal[i].Nombre);
            }
        }
    }

    public class Sirena: IPescado
    {
        public int Velocidad { get; set; }
        public Sirena(int velocidad)
        {
            this.Velocidad = Velocidad;
        }
        public string Nadar()
        {
            return $"La Sirena nada a una velocidad de {Velocidad} km/h";
        }

    }

    public class Tiburon: IAnimal, IPescado
    {
        public string Nombre { get; set; }
        public int Velocidad { get; set; }
        public Tiburon(string Nombre, int Velocidad)
        {
            this.Nombre = Nombre;
            this.Velocidad = Velocidad;
        }
        public string Nadar()
        {
            return $"{Nombre} nada a una velocidad de {Velocidad} km/h"; 
        }
    }

    public interface IAnimal
    {
        public string Nombre { get; set; }
    }

    public interface IPescado
    {
        public int Velocidad { get; set; }
        public string Nadar();
    }
}

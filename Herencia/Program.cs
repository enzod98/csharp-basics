using System;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("John", 75, "Urólogo");
            Console.WriteLine(doctor1.GetData());

            Desarrollador dev1 = new Desarrollador("Enzo", 23, "C#");
            Console.WriteLine(dev1.GetDesarrolladorData());
        }
    }

    class Persona
    {
        private string _nombre;
        private int _edad;
        public Persona(string nombre, int edad)
        {
            _nombre = nombre;
            _edad = edad;
        }

        public string GetInfo()
        {
            return _nombre + " " + _edad;
        }
    }

    class Doctor : Persona
    {
        private string _especialidad;
        public Doctor(string nombre, int edad, string especialidad) : base(nombre, edad)
        {
            _especialidad = especialidad;
        }

        public string GetData()
        {
            return GetInfo() + " " + _especialidad;
        }
    }

    class Desarrollador : Persona
    {
        private string _lenguaje;
        public Desarrollador(string nombre, int edad, string lenguaje) : base(nombre, edad)
        {
            _lenguaje = lenguaje;
        }
        public string GetDesarrolladorData()
        {
            return GetInfo() + " " + _lenguaje;
        }
    }
}

using System;
using System.Text.Json;

namespace JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerveza miCerveza = new Cerveza()
            {
                Nombre = "Mandioca",
                Marca = "Pilsen"
            };

            //Convertir un objeto a JSON
            string json = JsonSerializer.Serialize(miCerveza);
            //string json = "{\"Nombre\": \"Mandioca\", \"Marca\": \"Pilsen\"}";
            Console.WriteLine(json);

            //Convertir un JSON a objeto
            Cerveza cerveza = JsonSerializer.Deserialize<Cerveza>(json);
            Console.WriteLine(cerveza.Nombre);
            // LO MISMO PASA CON ARREGLOS
        }
    }

    public class Cerveza
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
    }
}

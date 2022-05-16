using System;

namespace ExcepcionPersonalizada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Beer cerveza = new Beer()
                {
                    Name = "Mandioca",
                    //Brand = "Pilsen"
                };

                Console.WriteLine(cerveza.ToString());
            } 
            catch (InvalidBeerException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class InvalidBeerException : Exception
    {
        public InvalidBeerException() : base("La cerveza no tiene nombre o marca, lo cual no es válido")
        {

        }
    }

    public class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public override string ToString()
        {
            if (Name == null || Brand == null)
                throw new InvalidBeerException();

            return $"Cerveza: {Name}, Marca: {Brand}";
        }
    }
}

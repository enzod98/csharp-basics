using System;

namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool hayLuz = false;
            bool estaLloviendo = true;

            if (hayLuz && estaLloviendo)
            {
                Console.WriteLine("Milagros Inesperados");
            } else if(!hayLuz && estaLloviendo)
            {
                Console.WriteLine("Lo normal");
            }
            else
            {
                Console.WriteLine("Llamar a la ANDE");
            }
        }
    }
}

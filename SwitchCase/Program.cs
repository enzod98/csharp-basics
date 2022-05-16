using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = -7;

            switch (op)
            {
                case 1:
                    Console.WriteLine("Seleccionaste el uno");
                    break;
                case 2:
                    Console.WriteLine("Seleccionaste el dos");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Seleccionaste tres o cuatro");
                    break;
                case < 0:
                case > 1000:
                    Console.WriteLine("Número inválido");
                    break;
                case > 4 and < 10:
                    Console.WriteLine("Tu número está entre 5 y 9");
                    break;
                default:
                    Console.WriteLine("Inválido");
                    break;
            }
        }
    }
}

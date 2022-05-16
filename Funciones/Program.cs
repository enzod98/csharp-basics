using System;

namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 8;

            Show();
            Suma(a, b);

            int multiplicacion = Multiplicar(a, b);
            Console.WriteLine(multiplicacion);
        }

        static int Multiplicar(int num1, int num2)
        {
            return num1 * num2; 
        }

        static void Suma(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        static void Show()
        {
            Console.WriteLine("Hola desde función");
        }

    }
}

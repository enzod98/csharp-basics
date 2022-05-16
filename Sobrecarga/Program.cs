using System;

namespace Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.Sum(1,2));
            Console.WriteLine(math.Sum("2", "85"));
            Console.WriteLine(math.Sum(new int[8] { 1,2,3,4,5,6,7,8 }));

        }
    }

    class Math
    {
        public int Sum(int a, int b)
        {
            return a + b;   
        }

        public int Sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }

        public int Sum(int[] numeros)
        {
            int suma = 0;
            for(int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i]; 
            }
            return suma;
        }
    }
}

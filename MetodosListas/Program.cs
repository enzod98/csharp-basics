using System;
using System.Collections.Generic;

namespace MetodosListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                1,4,5,6,8,7,19
            };

            Show(numbers);

            numbers.Insert(2, 108);
            Show(numbers);

            if(numbers.Contains(7))
                Console.WriteLine("Existe el 7!!");

            //IndexOf
            int pos = numbers.IndexOf(108);
            Console.WriteLine(pos);
            //SI NO EIXSTE, DEVUELVE -1
            int pos2 = numbers.IndexOf(1112108);
            Console.WriteLine(pos2);

            //Ordenar la lista
            numbers.Sort(); //esto modifica la lista original
            Show(numbers);

            //Añadir los valores de una lista distinta a nuestra lista
            numbers.AddRange(new List<int>()
            {
                1001,1002,1003,1004
            });

            Show(numbers);

        }

        public static void Show(List<int> numbers)
        {
            Console.WriteLine("-- NÚMEROS --");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

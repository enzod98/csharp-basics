using System;

namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[7]
            {
                "Miguel Angel",
                "Miguelma",
                "Fer",
                "Dani",
                "leSca",
                "Almirón",
                null
            };

            friends[6] = "John";

            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);
            Console.WriteLine(friends[4]);
            Console.WriteLine(friends[5]);
            Console.WriteLine(friends[6]);


        }
    }
}

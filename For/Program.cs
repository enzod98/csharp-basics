using System;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[6]
            {
                "Miguel Angel",
                "Miguelma",
                "Fer",
                "Dani",
                "leSca",
                "Almirón"
            };

            for(int i = 0; i < friends.Length && true; i++)
            {
                Console.WriteLine(friends[i]);
            }
        }
    }
}

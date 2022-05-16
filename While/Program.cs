﻿using System;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while(i < 10)
            {
                Console.WriteLine("Iteración de i: " + i);
                i++;
            }

            int j = 0;
            while (j < 100)
            {
                if (j > 10)
                    break;

                Console.WriteLine("Iteración de J: " + j);
                j++;
            }

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

            int index = 0;
            while(index < friends.Length)
            {
                Console.WriteLine(friends[index]);
                index++;
            }

            do
            {
                Console.WriteLine("Entró en lo falso");
            } while (false);
        }

    }
}

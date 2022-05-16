using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);

            Console.WriteLine(numbers.Count);

            List<int> numbers2 = new List<int>()
            {
                1, 2, 145, 784
            };

            Console.WriteLine(numbers2.Count);

            numbers.Clear();
            Console.WriteLine(numbers.Count);

            List<string> countries = new List<string>()
            {
                "paraguay", "peru", "argentina"
            };
        }
    }
}

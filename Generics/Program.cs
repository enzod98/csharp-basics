using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>(10);
            numbers.Add(20);
            numbers.Add(14);
            numbers.Add(23);
            numbers.Add(200);

            MyList<string> strings = new MyList<string>(5);
            strings.Add("e");
            strings.Add("ggg");
            strings.Add("AAHAHHHAHHH");

            MyList<Persona> personas = new MyList<Persona>(5);
            personas.Add(new Persona() { Nombre = "Enzo", Edad = 23 });
            personas.Add(new Persona() { Nombre = "Joao", Edad = 32 });


            Console.WriteLine(strings.GetElement(2));
            Console.WriteLine(numbers.GetString());
            Console.WriteLine(personas.GetString());

        }
    }

    public class Persona
    {
        public string Nombre{ get; set; }
        public int Edad { get; set; }
        public override string ToString()
        {
            return Nombre + ", " + Edad + " años";
        }
    }


    public class MyList<T>
    {
        private T[] _elements;
        private int _index = 0;

        public MyList(int n)
        {
            _elements = new T[n];
        }

        public void Add(T element)
        {
            if(_index < _elements.Length)
            {
                _elements[_index] = element;
                _index++;
            }
        }

        public T GetElement(int i)
        {
            if(i >=0 && i <= _index)
            {
                return _elements[i];
            }

            return default(T);
        }

        public string GetString()
        {
            string result = "";
            for(int i = 0; i< _index; i++)
            {
                result += _elements[i].ToString() + "|";
            }
            return result;
        }
    }
}

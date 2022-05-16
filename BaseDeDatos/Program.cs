using System;
using System.Collections.Generic;

namespace BaseDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeerDB beerDb = new BeerDB(@"localhost\SQLEXPRESS", "CsharpDB", "", "");
            bool again = true;
            int option = 0;

            do
            {
                ShowMenu();
                Console.WriteLine("ELIGE UNA OPCIÓN:");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ShowBeer(beerDb);
                        break;
                    case 2:
                        Add(beerDb);
                        break;
                    case 3:
                        Edit(beerDb);
                        break;
                    case 4:
                        Delete(beerDb);
                        break;
                    case 5:
                        again = false;
                        break;
                }

            }while(again);

        }

        public static void ShowMenu()
        {
            Console.WriteLine("\n--- MENU PRINCIPAL ---");
            Console.WriteLine("1- Mostrar");
            Console.WriteLine("2- Agregar");
            Console.WriteLine("3- Editar");
            Console.WriteLine("4- Eliminar");
            Console.WriteLine("5- Salir");
        }

        public static void ShowBeer(BeerDB beerDb)
        {
            Console.Clear();
            Console.WriteLine("--- CERVEZAS ---");
            List<Beer> cervezas = beerDb.GetAll();
            foreach (var cerveza in cervezas)
                Console.WriteLine(cerveza.ToString());
        }

        public static void Add(BeerDB beerDB)
        {
            Console.Clear();
            Console.WriteLine("--- AGREGAR NUEVA CERVEZA ---");
            Console.WriteLine("Escribe el nombre:");
            string name = Console.ReadLine();

            Console.WriteLine("Escribe el id de Marca:");
            int brandId = int.Parse(Console.ReadLine());

            Beer beer = new Beer(name, brandId);
            beerDB.Add(beer);
        }

        public static void Edit(BeerDB beerDb)
        {
            Console.Clear();
            ShowBeer(beerDb);
            Console.WriteLine("--- EDITAR CERVEZA ---");
            Console.WriteLine("Escribe el ID de tu cerveza a editar");
            int id = int.Parse(Console.ReadLine());
            Beer beer = beerDb.Get(id);
            if (beer == null)
            {
                Console.WriteLine("La cerveza no existe");
            }
            else
            {
                Console.WriteLine("Escribe el nuevo nombre:");
                string name = Console.ReadLine();
                Console.WriteLine("Escribe el id de la marca:");
                int brandId = int.Parse(Console.ReadLine());
                
                beer.Name = name;
                beer.BrandId = brandId;

                beerDb.Edit(beer);
            }
        }

        public static void Delete(BeerDB beerDb)
        {
            Console.Clear();
            ShowBeer(beerDb);
            Console.WriteLine("--- ELIMINAR CERVEZA ---");
            Console.WriteLine("Escribe el ID de tu cerveza a eliminar");
            int id = int.Parse(Console.ReadLine());
            Beer beer = beerDb.Get(id);
            if (beer == null)
            {
                Console.WriteLine("La cerveza no existe");
            }
            else
            {
                beerDb.Delete(id);
                Console.WriteLine("Cerveza eliminada.");
            }
        }
    }
}

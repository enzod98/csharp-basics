using BD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbContextOptionsBuilder<CsharpDBContext> optionsBuilder = 
                new DbContextOptionsBuilder<CsharpDBContext>();

            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=CsharpDB; Trusted_Connection=True");

            bool again = true;
            int selectedOption = 0;

            do
            {
                ShowMenu();
                Console.WriteLine("Elige una opción:");
                selectedOption = int.Parse(Console.ReadLine());

                switch (selectedOption)
                {
                    case 1:
                        Show(optionsBuilder);
                        break;
                    case 2:
                        Add(optionsBuilder);
                        break;
                    case 3:
                        Edit(optionsBuilder);
                        break;
                    case 4:
                        Delete(optionsBuilder);
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

        public static void Show(DbContextOptionsBuilder<CsharpDBContext> optionsBuilder)
        {
            Console.Clear();
            Console.WriteLine("Cervezas en la base de datos:");

            using (CsharpDBContext context = new CsharpDBContext(optionsBuilder.Options))
            {
                List<Beer> beers = (from b in context.Beers
                                     //where b.BrandId == 2
                                     orderby b.Name
                                     select b).Include(b=>b.Brand).ToList();

                foreach (var beer in beers)
                    Console.WriteLine($"{beer.Id}.- {beer.Name}, Marca {beer.Brand.Name}");
            }
        }

        public static void Add(DbContextOptionsBuilder<CsharpDBContext> optionsBuilder)
        {
            Console.Clear();
            Console.WriteLine("Agregar nueva cerveza");
            Console.WriteLine("Escribe el nombre:");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el id de marca:");
            int idBrand = int.Parse(Console.ReadLine());

            using(var context = new CsharpDBContext(optionsBuilder.Options))
            {
                Beer beer = new Beer()
                {
                    Name = name,
                    BrandId = idBrand
                };

                context.Add(beer);
                context.SaveChanges();
            }

        }

        public static void Edit(DbContextOptionsBuilder<CsharpDBContext> optionsBuilder)
        {
            Console.Clear();
            Console.WriteLine("Editar Cerveza");
            Show(optionsBuilder);
            Console.WriteLine("Escribe el id de la cerveza a editar");
            int id = int.Parse(Console.ReadLine());

            using(var context = new CsharpDBContext(optionsBuilder.Options))
            {
                Beer beer = context.Beers.Find(id);
                if(beer != null)
                {
                    Console.WriteLine("Escriba el nombre:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Escribe el id de la marca:");
                    int brandId = int.Parse(Console.ReadLine());
                    beer.Name = name;
                    beer.BrandId = brandId;

                    context.Entry(beer).State = EntityState.Modified;
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Su id no existe");
                }
            }

        }

        public static void Delete(DbContextOptionsBuilder<CsharpDBContext> optionsBuilder)
        {
            Console.Clear();
            Console.WriteLine("Eliminar Cerveza");
            Show(optionsBuilder);
            Console.WriteLine("Escribe el id de la cerveza a eliminar");
            int id = int.Parse(Console.ReadLine());

            using (var context = new CsharpDBContext(optionsBuilder.Options))
            {
                Beer beer = context.Beers.Find(id);
                if (beer != null)
                {
                    context.Beers.Remove(beer);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Su id no existe");
                }
            }
        }

    }
}

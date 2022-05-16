using System;
using System.IO;

namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\Enzo\Documents\hola.txt");
                Console.WriteLine(content);

                string content2 = File.ReadAllText(@"C:\Users\Enzo\Documents\hola2.txt");
                Console.WriteLine(content2);

                throw new Exception("Ocurrió algo fatal autodestructivo");

            } catch (FileNotFoundException ex)
            {
                Console.WriteLine("El archivo no existe");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Haya o no excepción, esta linea la ves");
            }
        }
    }
}

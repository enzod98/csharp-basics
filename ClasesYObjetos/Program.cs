using System;

namespace ClasesYObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sale venta1 = new Sale(150, DateTime.Now);
            Console.WriteLine(venta1.GetInfo());

            Sale venta2 = new Sale(750, DateTime.Now);
            Console.WriteLine(venta2.GetInfo());

        }
    }

    class Sale
    {
        int total;
        DateTime date;

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

        public string GetInfo()
        {
            return total + " " + date.ToLongDateString();
        }

        public void Show()
        {
            Console.WriteLine("Soy una venta");
        }
    }
}

using System;

namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sale venta = new Sale(150, DateTime.Now);
            venta.Total = -144;
            Console.WriteLine(venta.Total);
            Console.WriteLine(venta.Date);

        }
    }

    class Sale
    {
        private int total;
        private DateTime date;

        public string Date
        {
            get
            {
                return date.ToLongDateString();
            }
        }

        public int Total
        {
            get
            {
                return total;
            }
            set
            {
                if (value < 0)
                    value = 0;
                total = value;
            }
        }

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }
    }
}

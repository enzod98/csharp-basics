using System;

namespace Sobreescritura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            Console.WriteLine(b.Hi());

            Venta venta = new Venta(5);
            venta.Add(4);
            venta.Add(8);
            Console.WriteLine(venta.GetTotal());

            VentasConIVA ventaConIva = new VentasConIVA(10, 1.10m);
            ventaConIva.Add(4);
            ventaConIva.Add(8);
            Console.WriteLine(ventaConIva.GetTotal());


        }
    }

    public class Venta
    {
        private decimal[] _montos;
        private int _n;
        private int _end;
        public Venta(int n)
        {
            _montos = new decimal[n];
            _n = n;
            _end = 0;
        }

        public void Add(decimal monto)
        {
            if(_end < _n)
            {
                _montos[_end] = monto;
                _end++;
            }
        }

        public virtual decimal GetTotal()
        {
            decimal result = 0;
            for(int i = 0; i<= _end; i++)
            {
                result += _montos[i]; 
            }
            return result;
        }    
    }

    public class VentasConIVA : Venta
    {
        private decimal _porcentaje;
        public VentasConIVA(int n, decimal porcentaje) : base(n)
        {
            _porcentaje = porcentaje;
        }

        public override decimal GetTotal()
        {
            return base.GetTotal() * _porcentaje;
        }


    }



    public class A
    {
        public virtual string Hi()
        {
            return "Hola desde A";
        }
    }

    public class B : A
    {
        public override string Hi()
        {
            return base.Hi() + Environment.NewLine + "Hola desde B";
        }
    }
}

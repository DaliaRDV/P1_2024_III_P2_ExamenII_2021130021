using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2024_III_P2_ExamenII_2021130021.Objetos
{
    public class Factura
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public decimal TotalPagar { get; private set; }
        public List<Producto> Productos { get; set; }

        public Factura()
        {
            Productos = new List<Producto>();
        }

        public void CalcularTotalPagar()
        {
            TotalPagar = 0;
            foreach (var producto in Productos)
            {
                TotalPagar += producto.PrecioVenta;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine($"Factura ID: {Id}, Total a Pagar: {TotalPagar}");
            Cliente.Imprimir();
            Empleado.Imprimir();
            Console.WriteLine("Productos:");
            foreach (var producto in Productos)
            {
                producto.Imprimir();
            }
        }
    }
}

using P1_2024_III_P2_ExamenII_2021130021.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2024_III_P2_ExamenII_2021130021
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Empleado empleado = new Empleado
            {
                Id = 1,
                Nombre = "Juan",
                Apellido = "Pérez",
                Puesto = "Vendedor"
            };

            
            Cliente cliente = new Cliente
            {
                Id = 1,
                Nombre = "Ana",
                Apellido = "García",
                Categoria = "Regular"
            };

            
            Producto producto1 = new Producto { Id = 1, Nombre = "Producto A", PrecioCompra = 10, PrecioVenta = 15 };
            Producto producto2 = new Producto { Id = 2, Nombre = "Producto B", PrecioCompra = 20, PrecioVenta = 30 };
            Producto producto3 = new Producto { Id = 3, Nombre = "Producto C", PrecioCompra = 5, PrecioVenta = 10 };

            
            Factura factura = new Factura
            {
                Id = 1,
                Cliente = cliente,
                Empleado = empleado
            };

            
            factura.Productos.Add(producto1);
            factura.Productos.Add(producto2);
            factura.Productos.Add(producto3);

           
            factura.CalcularTotalPagar();

           
            factura.Imprimir();
        }
    }
}

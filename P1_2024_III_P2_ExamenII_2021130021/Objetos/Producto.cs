using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2024_III_P2_ExamenII_2021130021.Objetos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Producto ID: {Id}, Nombre: {Nombre}, Precio Compra: {PrecioCompra}, Precio Venta: {PrecioVenta}");
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2024_III_P2_ExamenII_2021130021.Objetos
{
    public class Cliente : Persona
    {
        public string Categoria { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Cliente ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Categoría: {Categoria}");
        }
    }
}

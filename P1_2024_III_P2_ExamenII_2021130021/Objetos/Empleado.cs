using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2024_III_P2_ExamenII_2021130021.Objetos
{
    public class Empleado : Persona
    {
        public string Puesto { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Empleado ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Puesto: {Puesto}");
        }
    }
}

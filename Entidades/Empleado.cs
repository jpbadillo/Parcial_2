using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        // Atributos o propiedades del empleado
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public double SalarioBase { get; set; }
        public string Estado { get; set; }

        // Constructor vacío del empleado
        public Empleado()
        {

        }

        // Constructor con parámetros del empleado
        public Empleado(string identificacion, string nombre, double salarioBase, string estado)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            SalarioBase = salarioBase;
            Estado = estado;

        }
    }
}





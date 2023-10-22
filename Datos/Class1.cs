using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosEmpleado
    {
        private string ruta = "empleados.txt";

        public void AgregarEmpleado(Empleado empleado)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine($"{empleado.Identificacion},{empleado.Nombre},{empleado.SalarioBase},{empleado.Estado}");
            sw.Close();
        }

        public List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            StreamReader sr = new StreamReader(ruta);
            string linea = sr.ReadLine();
            while (linea != null)
            {
                string[] datos = linea.Split(',');
                Empleado empleado = new Empleado();
                empleado.Identificacion = datos[0];
                empleado.Nombre = datos[1];
                empleado.SalarioBase = double.Parse(datos[2]);
                empleado.Estado = datos[3];
                empleados.Add(empleado);
                linea = sr.ReadLine();
            }
            sr.Close();
            return empleados;
        }

        public bool ExisteEmpleado(string identificacion)
        {
            List<Empleado> empleados = ObtenerEmpleados();
            foreach (Empleado empleado in empleados)
            {
                if (empleado.Identificacion == identificacion)
                {
                    return true;
                }
            }
            return false;
        }
    }
}


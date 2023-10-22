using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaEmpleado
    {
        private DatosEmpleado datosEmpleado = new DatosEmpleado();

        public string ValidarEmpleado(Empleado empleado)
        {
            if (empleado.Identificacion == "")
            {
                return "El campo identificación está vacío.";
            }
            if (empleado.Nombre == "")
            {
                return "El campo nombre está vacío.";
            }
            if (empleado.SalarioBase == 0)
            {
                return "El campo salario base está vacío.";
            }
            if (empleado.Estado == "")
            {
                return "El campo estado está vacío.";
            }

            foreach (char c in empleado.Nombre)
            {
                if (!char.IsLetter(c))
                {
                    return "El nombre solo puede contener letras.";
                }
            }

            if (empleado.Estado != "activo" && empleado.Estado != "inactivo")
            {
                return "El estado solo puede ser activo o inactivo.";
            }

            if (datosEmpleado.ExisteEmpleado(empleado.Identificacion))
            {
                return "El empleado ya existe.";
            }

            return "";
        }

        public string AgregarEmpleado(Empleado empleado)
        {
            string mensaje = ValidarEmpleado(empleado);
            if (mensaje == "")
            {
                datosEmpleado.AgregarEmpleado(empleado);
                return "El empleado se ha registrado exitosamente.";
            }
            else
            {
                return mensaje;
            }
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return datosEmpleado.ObtenerEmpleados();
        }

        public List<Empleado> FiltrarPorEstado(List<Empleado> empleados, string estado)
        {
            List<Empleado> empleadosFiltrados = new List<Empleado>();
            foreach (Empleado empleado in empleados)
            {
                if (empleado.Estado == estado)
                {
                    empleadosFiltrados.Add(empleado);
                }
            }
            return empleadosFiltrados;
        }

        public List<Empleado> FiltrarPorNombre(List<Empleado> empleados, string nombre)
        {
            List<Empleado> empleadosFiltrados = new List<Empleado>();
            foreach (Empleado empleado in empleados)
            {
                if (empleado.Nombre.Contains(nombre))
                {
                    empleadosFiltrados.Add(empleado);
                }
            }
            return empleadosFiltrados;
        }
    }
}


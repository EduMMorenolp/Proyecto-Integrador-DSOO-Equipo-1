using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Models
{
    public abstract class Persona
    {
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected string Dni { get; set; }
        protected DateTime FechaNacimiento { get; set; }

        public Persona(string nombre, string apellido, string dni, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaNacimiento = fechaNacimiento;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Apellido: {Apellido}, Dni: {Dni}, Fecha de nacimiento: {FechaNacimiento.ToShortDateString()}";
        }

        public abstract void registrarse();

        public abstract bool pagar(float monto);

        public void hacerActividad(Actividad actividad)
        {
# TO DO
        }
    }
}

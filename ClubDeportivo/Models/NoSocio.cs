using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Models
{
    public class NoSocio : Persona
    {
        private int Id { get; set; }
        private List<Actividad> Actividades;
        private List<DateTime> DiasPagados;

        public NoSocio(string nombre, string apellido, string dni, DateTime fechaNacimiento, List<Actividad> actividades, List<DateTime> diasPagados) : base(nombre, apellido, dni, fechaNacimiento)
        {
            Actividades = actividades ?? new List<Actividad>();
            DiasPagados = diasPagados ?? new List<DateTime>();
        }

        public NoSocio() : base() // Llama al constructor por defecto de Persona
        {
            Actividades = new List<Actividad>();
            DiasPagados = new List<DateTime>();
        }
        public override void registrarse()
        {
            // TO DO
        }

        public override bool pagar(float monto)
        {
            // TO DO
            return true;
        }




    }
    
}



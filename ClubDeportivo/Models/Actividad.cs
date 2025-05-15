using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Models
{
    public class Actividad
    {
        public int IdActividad { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Profesor { get; set; }
        public string Horario { get; set; }
        public int Capacidad { get; set; }
        public decimal Costo { get; set; }
    }
}

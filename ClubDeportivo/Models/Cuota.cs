using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Models
{
    public class Cuota
    {
        public int IdCuota { get; set; }
        public int IdSocio { get; set; }
        public float Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVence { get; set; }
        public string MedioPago { get; set; } 
        public int Promocion { get; set; } 
    }
}

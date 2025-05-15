using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Models
{
    public class Socio : Persona
    {
        public int IdSocio { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime CuotaHasta { get; set; }
        public bool TieneCarnet { get; set; }
        public bool FichaMedica { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Models
{
    public class Cuota
    {
        private int IdSocio { get; set; }
        private bool Tipo { get; set; }
        private float Monto { get; set; }
        private DateTime FechaPago { get; set; }
        private DateTime FechaVence { get; set; }
        private string MedioPago { get; set; }
        private int Promocion { get; set; }

        public Cuota(int idSocio, bool tipo, float monto, DateTime fechaPago, DateTime fechaVence, string medioPago, int promocion)
        {
            this.IdSocio = idSocio;
            this.Tipo = tipo;
            this.Monto = monto;
            this.FechaPago = fechaPago;
            this.FechaVence = fechaVence;
            this.MedioPago = medioPago;
            this.Promocion = promocion;
        }

        public DateTime calcularVencimiento()
        {
# TO DO
        }

        public bool esValida() {
# TO DO
        }
    }
}

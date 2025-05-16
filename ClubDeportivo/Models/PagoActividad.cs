using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Models
{
    public class PagoActividad
    {
        private int Id { get; set; }
        private DateTime Fecha { get; set; }
        private float MontoAPagar { get; set; }

        public PagoActividad(DateTime fecha, float montoAPagar)
        {
            Fecha = fecha;
            MontoAPagar = montoAPagar;
        }

        public override void generarRecibo(date fechaActual, float monto)
        {
# TO DO
        }
    }
}



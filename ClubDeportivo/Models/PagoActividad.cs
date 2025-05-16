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

        public void generarRecibo(DateTime fechaActual, float monto)
        {
            // TO DO
        }
    }
}



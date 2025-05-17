namespace ClubDeportivo.Models
{
    public class Socio : Persona
    {
        private int IdSocio { get; set; }
        private DateTime FechaAlta { get; set; }
        private DateTime CuotaHasta { get; set; }
        private bool TieneCarnet { get; set; }
        private bool FichaMedica { get; set; }
        private List<Actividad> Actividades;

        public Socio(string nombre, string apellido, string dni, DateTime fechaNacimiento, DateTime fechaAlta, DateTime cuotaHasta, bool tieneCarnet, bool fichaMedica, List<Actividad> actividades) : base(nombre, apellido, dni, fechaNacimiento)
        {
            FechaAlta = fechaAlta;
            CuotaHasta = cuotaHasta;
            TieneCarnet = tieneCarnet;
            FichaMedica = fichaMedica;
            Actividades = actividades;
        }

        public DateTime obtenerVencimientoCuota()
        {
            // TO DO
            return new DateTime();
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



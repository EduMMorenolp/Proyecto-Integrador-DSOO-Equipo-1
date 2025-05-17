namespace ClubDeportivo.Models
{
    public class Socio : Persona
    {
        public int IdSocio { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? CuotaHasta { get; set; } // Nullable DateTime por si socio nuevo no ha pagado su primera cuota
        public bool TieneCarnet { get; set; }
        public bool FichaMedica { get; set; }

        public List<Actividad> Actividades { get; set; }

        public Socio(string nombre, string apellido, string dni, DateTime fechaNacimiento,
            DateTime fechaAlta, bool tieneCarnet, bool fichaMedica, List<Actividad> actividades, DateTime? cuotaHasta = null)
            : base(nombre, apellido, dni, fechaNacimiento)
        {
            FechaAlta = fechaAlta;
            CuotaHasta = cuotaHasta;
            TieneCarnet = tieneCarnet;
            FichaMedica = fichaMedica;
            Actividades = actividades ?? new List<Actividad>();
        }

        public Socio() : base()
        {
            Actividades = new List<Actividad>();
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



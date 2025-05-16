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

        public Actividad(string nombre, string tipo, string profesor, string horario, int capacidad, decimal costo) {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Profesor = profesor;
            this.Horario = horario;
            this.Capacidad  = capacidad;
            this.Costo = costo;
        }

        public bool inscribir(Persona persona)
        {
          // TO DO
            return true;
        }
    }
}

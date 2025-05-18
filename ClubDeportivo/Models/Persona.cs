namespace ClubDeportivo.Models
{
    public abstract class Persona
    {
        public int IdPersona { get; set; } // ID tabla Persona (PK, Auto_Increment)
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }

        protected Persona(string nombre, string apellido, string dni, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaNacimiento = fechaNacimiento;
        }

        protected Persona() { }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Apellido: {Apellido}, Dni: {Dni}, Fecha de nacimiento: {FechaNacimiento.ToShortDateString()}";
        }

        public abstract void registrarse();

        public abstract bool pagar(float monto);

        public void hacerActividad(Actividad actividad)
        {
            // TO DO
        }
    }
}

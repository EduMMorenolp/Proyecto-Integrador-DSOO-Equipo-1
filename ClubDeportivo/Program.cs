namespace ClubDeportivo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
            Socio nuevoSocio = new Socio(
                nombre = "juan",
                apellido = "perez",
                dni = "33111222",
                fechaNacimiento = new DateTime ( 1990, 1, 1),
                fechaAlta = DateTime.now,
                cuotaHasta = DateTime.now.AddMonths(1),
                tieneCarnet = True,
                fichaMedica = True,
                //actividades = no se como poner actividades
            )
            
        }
    }
}

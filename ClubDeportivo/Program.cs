using ClubDeportivo.Controllers.Forms;

namespace ClubDeportivo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Mostrar FrmLogin al inicio
            Application.Run(new FrmLogin());
            
        }
    }
}

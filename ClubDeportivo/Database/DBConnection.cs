using MySql.Data.MySqlClient;

namespace ClubDeportivo.Database
{
    public static class DBConnection
    {
        // Datos por defecto (valores iniciales)
        private static string servidor = "localhost";
        private static string puerto = "3306";
        private static string usuario = "root";
        private static string password = "root";
        private static string database = "club_deportivo";

        // Cadena de conexión construida a partir de los valores anteriores
        private static string connectionString = $"datasource={servidor};port={puerto};username={usuario};password={password};database={database};";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Método para actualizar la cadena de conexión con nuevos valores
        public static void ActualizarConnectionString(string nuevoServidor, string nuevoPuerto,
                                                      string nuevoUsuario, string nuevaPassword,
                                                      string nuevaBaseDatos)
        {
            servidor = nuevoServidor;
            puerto = nuevoPuerto;
            usuario = nuevoUsuario;
            password = nuevaPassword;
            database = nuevaBaseDatos;

            connectionString = $"datasource={servidor};port={puerto};username={usuario};password={password};database={database};";
        }
        public static void ConfigurarConexionManual()
        {
            bool correcto = false;

            while (!correcto)
            {
                string inputServidor = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el servidor:", "Configuración de conexión", servidor);

                string inputPuerto = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el puerto:", "Configuración de conexión", puerto);

                string inputUsuario = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el usuario:", "Configuración de conexión", usuario);

                string inputClave = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese la contraseña:", "Configuración de conexión", password);

                string inputBaseDatos = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el nombre de la base de datos:", "Configuración de conexión", database);

                DialogResult confirm = MessageBox.Show(
                    $"¿Los siguientes datos son correctos?\n" +
                    $"Servidor: {inputServidor}\n" +
                    $"Puerto: {inputPuerto}\n" +
                    $"Usuario: {inputUsuario}\n" +
                    $"Contraseña: {inputClave}\n" +
                    $"Base de datos: {inputBaseDatos}",
                    "Confirmar datos",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    ActualizarConnectionString(inputServidor, inputPuerto, inputUsuario, inputClave, inputBaseDatos);
                    correcto = true;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese nuevamente los datos.", "Reingreso requerido");
                }
            }
        }
    }
}

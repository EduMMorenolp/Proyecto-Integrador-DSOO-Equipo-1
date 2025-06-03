using ClubDeportivo.Database;
using MySql.Data.MySqlClient;
using System.Data;

namespace ClubDeportivo.Controllers.Forms.PantallaPrincipal
{
    public partial class FrmListarCuotasVencidas : Form
    {
        public FrmListarCuotasVencidas()
        {
            InitializeComponent();
            cargarGrilla();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }
        public void cargarGrilla()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "select t2.id_socio, concat(t1.nombre ,\" \", t1.apellido) as \"nombre y apellido\" , t1.dni, cuota_hasta, IF(t2.cuota_hasta < CURDATE(), 'VENCIDA', 'AL DÍA') AS estado_cuota from persona as t1, socio as t2 where t1.id_persona = t2.id_persona;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlCommand command = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                }
            }
        }

        public void cargarGrillaVencida()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "select t2.id_socio, concat(t1.nombre ,\" \", t1.apellido) as \"nombre y apellido\" , t1.dni, cuota_hasta, IF(t2.cuota_hasta < CURDATE(), 'VENCIDA', 'AL DÍA') AS estado_cuota from persona as t1, socio as t2 where t1.id_persona = t2.id_persona having estado_cuota = 'VENCIDA';";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlCommand command = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;

                }
            }
        }

        public void cargarGrillaAldia()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "select t2.id_socio, concat(t1.nombre ,\" \", t1.apellido) as \"nombre y apellido\" , t1.dni, cuota_hasta, IF(t2.cuota_hasta < CURDATE(), 'VENCIDA', 'AL DÍA') AS estado_cuota from persona as t1, socio as t2 where t1.id_persona = t2.id_persona having estado_cuota = 'AL DIA';";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlCommand command = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;

                }
            }
        }

        private void btnVerTodas_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnVerVencidas_Click(object sender, EventArgs e)
        {
            cargarGrillaVencida();
        }

        private void btnVerNoVencidas_Click(object sender, EventArgs e)
        {
            cargarGrillaAldia();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Filtrar Busqueda de DNI
        }

        // TO DO:
        // Al hacer click en filtrar:
        // - Validar que el valor del campo sea un numero y que sea menor a 10 digitos
        // - Verificar que el socio existe
        // - Crear un groupBox dinamicamente con el DNI del usuario y si la cuota esta vencida o no

        // Al hacer click en ver vencidas:
        // - Obtener de la base de datos el DNI de los socios cuya cuota esta vencida
        // - Crear un groupBox dinamicamente por cada socio donde se vea el DNI y que la cuota esta vencida

        // Al hacer click en ver no vencidas:
        // - Obtener de la base de datos el DNI de los socios cuya cuota NO esta vencida
        // - Crear un groupBox dinamicamente por cada socio donde se vea el DNI y que la cuota NO esta vencida

        // Al hacer click en ver todas:
        // - Obtener de la base de datos el DNI de todos los socios
        // - Crear un groupBox dinamicamente por cada socio donde se vea el DNI y si la cuota esta o no vencida
    }
}

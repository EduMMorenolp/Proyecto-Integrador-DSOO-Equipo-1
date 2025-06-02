using ClubDeportivo.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ClubDeportivo.Controllers.Forms.PantallaPrincipal
{
  
    public partial class FrmListarCuotasVencidas : Form
    {

        /*private DataTable datosOriginales;

        private DataTable datosCompletos; // Almacena todos los datos sin filtrar
        private DataView vistaFiltrada;*/

        public FrmListarCuotasVencidas()
        {
             

            InitializeComponent();
            /*searchTimer.Interval = 300;
            searchTimer.Tick += SearchTimer_Tick;*/
            cargarGrilla();
            lblResultados.Text = "";
                       
         
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

                    //vistaFiltrada = new DataView(datosOriginales);

                    dataGridView1.DataSource = dataTable;

                    //no se como se come esto.
                    //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    //dataGridView1.ReadOnly = true;
                    //dataGridView1.AllowUserToAddRows = false;

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

                    //no se como se come esto.
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

                    //no se como se come esto.
                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;

                }
            }
        }



        private void btnVerTodas_Click(object sender, EventArgs e)
        {
            //dataGridView1
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

        /*
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto de búsqueda en minúsculas para hacer la comparación insensible a mayúsculas
            string filtro = txtBusqueda.Text.ToLower();

            // Verificar si el DataGridView tiene datos
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                // Aplicar filtro a la vista (DataView)
                DataView dv = dataTable.DefaultView;

                // Construir la expresión de filtro para todas las columnas
                string expresionFiltro = "";

                foreach (DataColumn columna in dataTable.Columns)
                {
                    if (expresionFiltro.Length > 0)
                        expresionFiltro += " OR ";

                    // Para columnas de tipo string
                    if (columna.DataType == typeof(string))
                    {
                        expresionFiltro += $"{columna.ColumnName} LIKE '%{filtro}%'";
                    }
                    // Para otros tipos (convertimos a string para buscar)
                    else
                    {
                        expresionFiltro += $"CONVERT({columna.ColumnName}, 'System.String') LIKE '%{filtro}%'";
                    }
                }

                dv.RowFilter = expresionFiltro;
            }
        }
        */

        /*
         * private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto de búsqueda
            string filtro = txtBusqueda.Text.Trim().ToLower();

            // Verificar si el DataGridView tiene datos y está vinculado a un DataTable
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                // Obtener la vista de datos para aplicar el filtro
                DataView dv = dataTable.DefaultView;

                if (string.IsNullOrEmpty(filtro))
                {
                    // Si no hay filtro, mostrar todos los registros
                    dv.RowFilter = "";
                }
                else
                {
                    // Construir la expresión de filtro dinámico
                    StringBuilder filterExpression = new StringBuilder();

                    // Recorrer todas las columnas buscables
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        if (filterExpression.Length > 0)
                            filterExpression.Append(" OR ");

                        // Filtrar cualquier columna que contenga el texto (insensible a mayúsculas)
                        filterExpression.Append($"Convert([{column.ColumnName}], 'System.String').ToLower() LIKE '%{filtro}%'");
                    }

                    // Aplicar el filtro
                    dv.RowFilter = filterExpression.ToString();
                }
            }
        }*/


        /*
        private DataTable datosOriginales;
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (datosOriginales == null) return;

            string filtro = txtBusqueda.Text.Trim().ToLower();

            DataView dv = new DataView(datosOriginales);

            if (string.IsNullOrEmpty(filtro))
            {
                dataGridView1.DataSource = datosOriginales;
            }
            else
            {
                StringBuilder filterExpression = new StringBuilder();

                foreach (DataColumn column in datosOriginales.Columns)
                {
                    if (filterExpression.Length > 0)
                        filterExpression.Append(" OR ");

                    filterExpression.Append($"(Convert([{column.ColumnName}], 'System.String') LIKE '%{filtro}%')");
                }

                dv.RowFilter = filterExpression.ToString();
                dataGridView1.DataSource = dv.ToTable(); // Convertir DataView a DataTable
            }

            ConfigurarDataGridView();
        }
        */

        /*
         * private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            AplicarFiltro();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void AplicarFiltro()
        {
            if (datosOriginales == null) return;

            string filtro = txtBusqueda.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filtro))
            {
                dataGridView1.DataSource = datosOriginales;
            }
            else
            {
                DataView dv = new DataView(datosOriginales);
                dv.RowFilter = $"Convert([id_socio], 'System.String') LIKE '%{filtro}%' OR " +
                              $"Convert([nombre y apellido], 'System.String') LIKE '%{filtro}%' OR " +
                              $"Convert([dni], 'System.String') LIKE '%{filtro}%' OR " +
                              $"Convert([cuota_hasta], 'System.String') LIKE '%{filtro}%' OR " +
                              $"Convert([estado_cuota], 'System.String') LIKE '%{filtro}%'";

                dataGridView1.DataSource = dv.ToTable();
            }

            ConfigurarDataGridView();
        }*/

        /*private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (datosCompletos == null) return;

            string filtro = txtBusqueda.Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(filtro))
                {
                    vistaFiltrada.RowFilter = "";
                }
                else
                {
                    // Para nombres de columnas con espacios, usamos corchetes
                    string filtroFinal = $@"
                [id_socio] LIKE '%{filtro}%' OR 
                [nombre y apellido] LIKE '%{filtro}%' OR 
                [dni] LIKE '%{filtro}%' OR 
                [cuota_hasta] LIKE '%{filtro}%' OR 
                [estado_cuota] LIKE '%{filtro}%'";

                    vistaFiltrada.RowFilter = filtroFinal;
                }

                // Actualizar el contador de resultados
                lblResultados.Text = $"{vistaFiltrada.Count} registros encontrados";

                Console.WriteLine($"Filtro aplicado: {vistaFiltrada.RowFilter}");
                Console.WriteLine($"Registros visibles: {vistaFiltrada.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar: {ex.Message}\n\nFiltro aplicado: {vistaFiltrada.RowFilter}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        /*
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (datosOriginales == null || vistaFiltrada == null) return;

            string filtro = txtBusqueda.Text.Trim();

            try
            {
                if (string.IsNullOrWhiteSpace(filtro))
                {
                    vistaFiltrada.RowFilter = string.Empty;
                }
                else
                {
                    // Construcción SEGURA del filtro
                    var filtros = new List<string>();

                    foreach (DataColumn col in datosOriginales.Columns)
                    {
                        string nombreColumna = col.ColumnName;

                        // Manejo especial para columnas de fecha
                        if (col.DataType == typeof(DateTime))
                        {
                            filtros.Add($"CONVERT({nombreColumna}, 'System.String') LIKE '%{filtro}%'");
                        }
                        else
                        {
                            filtros.Add($"{nombreColumna} LIKE '%{filtro}%'");
                        }
                    }

                    vistaFiltrada.RowFilter = string.Join(" OR ", filtros);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al filtrar: {ex.Message}");
                // Opcional: Mostrar mensaje al usuario
            }
        }
        */

        /*private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (datosOriginales == null) return;

            string filtro = txtBusqueda.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(filtro))
            {
                dataGridView1.DataSource = datosOriginales;
                return;
            }

            // Filtrado manual - 100% efectivo
            var resultados = datosOriginales.AsEnumerable()
                .Where(row => row.ItemArray
                    .Any(cell => cell?.ToString()?.ToLower().Contains(filtro) ?? false))
                .CopyToDataTable();

            dataGridView1.DataSource = resultados;
            ConfigurarDataGridView();
        }*/



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

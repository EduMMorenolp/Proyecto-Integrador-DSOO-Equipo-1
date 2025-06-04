using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Database; // Para DBConnection
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Controllers.Forms.PantallaPrincipal
{
    public partial class FrmListaActividades : Form
    {
        public FrmListaActividades()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarTodasLasActividades();
            PoblarComboTiposActividadDesdeBD();

        }
        private void ConfigurarDataGridView()
        {
            dgvActividades.AutoGenerateColumns = true; // O puedes definir columnas manualmente
            dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvActividades.ReadOnly = true;
            dgvActividades.AllowUserToAddRows = false;
            dgvActividades.MultiSelect = false;
            dgvActividades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarTodasLasActividades()
        {
            CargarGrillaActividades(); // Llama al método general sin filtros específicos
        }

        // Método general para cargar la grilla, puede ser adaptado para filtros
        public void CargarGrillaActividades(string filtroNombre = "", string filtroTipo = "", string filtroProfesor = "")
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    // Construir la query base
                    string query = "SELECT id_actividad AS 'IdActividad', nombre AS 'Nombre', tipo AS Tipo, " +
                                   "profesor AS Profesor, horario AS Horario, capacidad AS Capacidad, " +
                                   "costo_actividad AS Costo FROM Actividad WHERE 1=1"; // WHERE 1=1 para facilitar añadir ANDs

                    // Añadir condiciones de filtro si se proporcionaron
                    if (!string.IsNullOrWhiteSpace(filtroNombre))
                    {
                        query += " AND nombre LIKE @nombre";
                    }
                    if (!string.IsNullOrWhiteSpace(filtroTipo) && filtroTipo.ToLower() != "todos") // Asumiendo "todos" como opción de no filtrar
                    {
                        query += " AND tipo = @tipo";
                    }
                    if (!string.IsNullOrWhiteSpace(filtroProfesor))
                    {
                        query += " AND profesor LIKE @profesor";
                    }

                    query += " ORDER BY nombre;"; // Opcional: ordenar

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Añadir parámetros de filtro si es necesario
                        if (!string.IsNullOrWhiteSpace(filtroNombre))
                        {
                            cmd.Parameters.AddWithValue("@nombre", "%" + filtroNombre + "%"); // Usar LIKE para búsqueda parcial
                        }
                        if (!string.IsNullOrWhiteSpace(filtroTipo) && filtroTipo.ToLower() != "todos")
                        {
                            cmd.Parameters.AddWithValue("@tipo", filtroTipo);
                        }
                        if (!string.IsNullOrWhiteSpace(filtroProfesor))
                        {
                            cmd.Parameters.AddWithValue("@profesor", "%" + filtroProfesor + "%");
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvActividades.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las actividades: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PoblarComboTiposActividadDesdeBD()
        {
            cmbTipoActividad.Items.Clear();
            cmbTipoActividad.Items.Add("Todos"); // Siempre tener la opción de "Todos"

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    // Query para obtener los tipos distintos de actividad
                    string query = "SELECT DISTINCT tipo FROM Actividad WHERE tipo IS NOT NULL AND tipo <> '' ORDER BY tipo";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbTipoActividad.Items.Add(reader["tipo"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos de actividad: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cmbTipoActividad.Items.Count > 0)
            {
                cmbTipoActividad.SelectedIndex = 0; // Seleccionar "Todos" por defecto
            }
            cmbTipoActividad.DropDownStyle = ComboBoxStyle.DropDownList; // Opcional
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProfesor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string nombreFiltro = txtNombre.Text.Trim();
            string tipoFiltro = cmbTipoActividad.SelectedItem?.ToString() ?? ""; // Manejar si no hay nada seleccionado
            string profesorFiltro = txtProfesor.Text.Trim();

            CargarGrillaActividades(nombreFiltro, tipoFiltro, profesorFiltro);
        }

        private void btnVerTodas_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            cmbTipoActividad.SelectedIndex = -1; // O al ítem "Todos"
            txtProfesor.Clear();
            CargarTodasLasActividades();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

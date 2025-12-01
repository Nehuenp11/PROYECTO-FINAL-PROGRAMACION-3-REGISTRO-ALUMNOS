using SistemaAlumnos.FE.Models;
using SistemaAlumnos.FE.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace SistemaAlumnos.FE
{
    public partial class Registro : Form
    {
        private readonly AlumnoService _service;
        private int _idSeleccionado = 0;

        public Registro()
        {
            InitializeComponent();

            // Fuente moderna y fondo claro
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.BackColor = Color.WhiteSmoke;

            ConfigurarDataGridView();

            // Botones estilizados con hover
            EstilizarBoton(btn_Agregaralumno, Color.MediumSeaGreen);
            EstilizarBoton(btn_Actualizar, Color.SteelBlue);
            EstilizarBoton(btn_Eliminar, Color.IndianRed);

            btn_Actualizar.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_Agregaralumno.Enabled = true;

            ConfigurarPlaceholders();

            // Configurar HttpClient (ignorar certificado para pruebas locales)
            var handler = new System.Net.Http.HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            var httpClient = new System.Net.Http.HttpClient(handler)
            {
                BaseAddress = new Uri("http://localhost:5134/")
            };

            _service = new AlumnoService(httpClient);

            // Inicializar servicio de materias
            _materiaService = new MateriaService(httpClient);
            //MateriaService = _materiaService;

            // Cargar datos al iniciar
            _ = CargarAlumnosAsync();
            _ = CargarMateriasAsync();
        }

        private void ConfigurarDataGridView()
        {
            dgv_Alumnos.ReadOnly = true;
            dgv_Alumnos.AllowUserToAddRows = false;
            dgv_Alumnos.AllowUserToDeleteRows = false;
            dgv_Alumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Alumnos.MultiSelect = false;

            // Estilo DataGridView
            dgv_Alumnos.BackgroundColor = Color.White;
            dgv_Alumnos.BorderStyle = BorderStyle.None;
            dgv_Alumnos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv_Alumnos.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dgv_Alumnos.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_Alumnos.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgv_Alumnos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Alumnos.EnableHeadersVisualStyles = false;

            // Extra: fuentes y alineación
            dgv_Alumnos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv_Alumnos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Alumnos.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgv_Alumnos.RowTemplate.Height = 28;
            dgv_Alumnos.GridColor = Color.LightGray;
        }

        private void EstilizarBoton(Button btn, Color color)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.FlatAppearance.BorderSize = 0;

            // Hover
            btn.MouseEnter += (s, e) => btn.BackColor = ControlPaint.Light(color);
            btn.MouseLeave += (s, e) => btn.BackColor = color;
        }

        private void ConfigurarPlaceholders()
        {
            ConfigurarPlaceholder(txt_Nombre, "Ingrese nombre...");
            ConfigurarPlaceholder(txt_Apellido, "Ingrese apellido...");
            ConfigurarPlaceholder(txt_Legajo, "Ingrese legajo...");
        }

        private void ConfigurarPlaceholder(TextBox txt, string placeholder)
        {
            txt.ForeColor = Color.Gray;
            txt.Text = placeholder;

            txt.GotFocus += (s, e) =>
            {
                if (txt.Text == placeholder)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                }
            };

            txt.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Gray;
                }
            };
        }

        private async Task CargarAlumnosAsync()
        {
            dgv_Alumnos.DataSource = await _service.ObtenerAlumnosAsync();

            // Personalizar encabezados
            dgv_Alumnos.Columns["Id"].HeaderText = "Código";
            dgv_Alumnos.Columns["Nombre"].HeaderText = "Nombre del Alumno";
            dgv_Alumnos.Columns["Apellido"].HeaderText = "Apellido del Alumno";
            dgv_Alumnos.Columns["Legajo"].HeaderText = "N° Legajo";
            dgv_Alumnos.Columns["FechaNacimiento"].HeaderText = "Fecha de Nacimiento";

            // Formato de fecha
            dgv_Alumnos.Columns["FechaNacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void LimpiarCampos()
        {
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Legajo.Clear();
            dtp_FechaNac.Value = DateTime.Now;
            _idSeleccionado = 0;

            btn_Agregaralumno.Enabled = true;
            btn_Actualizar.Enabled = true;
            btn_Eliminar.Enabled = true;
        }

        private bool EsMayorDe16(DateTime fechaNacimiento)
        {
            var edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad)) edad--;
            return edad >= 16;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_Apellido.Text) ||
                string.IsNullOrWhiteSpace(txt_Legajo.Text))
            {
                MessageBox.Show("Nombre, Apellido y Legajo son obligatorios");
                return;
            }

            if (!EsMayorDe16(dtp_FechaNac.Value))
            {
                MessageBox.Show("El alumno debe ser mayor de 16 años");
                return;
            }

            var nuevo = new Alumno
            {
                Nombre = txt_Nombre.Text,
                Apellido = txt_Apellido.Text,
                Legajo = txt_Legajo.Text,
                FechaNacimiento = dtp_FechaNac.Value
            };

            bool exito = await _service.AgregarAlumnoAsync(nuevo);
            MessageBox.Show(exito ? "Alumno agregado correctamente" : "Error al agregar alumno");
            await CargarAlumnosAsync();
            LimpiarCampos();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un alumno para actualizar");
                return;
            }

            if (!EsMayorDe16(dtp_FechaNac.Value))
            {
                MessageBox.Show("El alumno debe ser mayor de 16 años");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_Apellido.Text) ||
                string.IsNullOrWhiteSpace(txt_Legajo.Text))
            {
                MessageBox.Show("Nombre, Apellido y Legajo son obligatorios");
                return;
            }

            var actualizado = new Alumno
            {
                Id = _idSeleccionado,
                Nombre = txt_Nombre.Text,
                Apellido = txt_Apellido.Text,
                Legajo = txt_Legajo.Text,
                FechaNacimiento = dtp_FechaNac.Value
            };

            bool exito = await _service.ActualizarAlumnoAsync(actualizado);
            MessageBox.Show(exito ? "Alumno actualizado correctamente" : "Error al actualizar alumno");
            await CargarAlumnosAsync();
            LimpiarCampos();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un alumno para eliminar");
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro de eliminar este alumno?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool exito = await _service.EliminarAlumnoAsync(_idSeleccionado);
                MessageBox.Show(exito ? "Alumno eliminado correctamente" : "Error al eliminar alumno");
                await CargarAlumnosAsync();
                LimpiarCampos();
            }
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_Alumnos.Rows[e.RowIndex];
                txt_Nombre.Text = row.Cells["Nombre"].Value?.ToString();
                txt_Apellido.Text = row.Cells["Apellido"].Value?.ToString();
                txt_Legajo.Text = row.Cells["Legajo"].Value?.ToString();
                dtp_FechaNac.Value = Convert.ToDateTime(row.Cells["FechaNacimiento"].Value);
                _idSeleccionado = Convert.ToInt32(row.Cells["Id"].Value);

                btn_Agregaralumno.Enabled = false; // Desactiva Agregar
                btn_Actualizar.Enabled
                    = true;
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        public void dgv_Alumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MostrarSeleccionAlumnoYMateria()
        {
            var alumnoRow = dgv_Alumnos.CurrentRow;
            var materiaRow = Dgv_materias.CurrentRow;

            if (alumnoRow == null || materiaRow == null)
            {
                MessageBox.Show("Seleccione una fila en 'Alumnos' y otra en 'Materias' antes de continuar.",
                                "Selección incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string GetCellValue(DataGridViewRow r, string columnName) =>
                r.Cells[columnName]?.Value?.ToString() ?? "";

            var nombre = GetCellValue(alumnoRow, "Nombre");
            var apellido = GetCellValue(alumnoRow, "Apellido");
            var legajo = GetCellValue(alumnoRow, "Legajo");
            var fechaNac = alumnoRow.Cells["FechaNacimiento"]?.Value is DateTime d
                ? d.ToString("dd/MM/yyyy")
                : GetCellValue(alumnoRow, "FechaNacimiento");

            var mId = GetCellValue(materiaRow, "Id");
            var mNombre = GetCellValue(materiaRow, "Nombre");
            var mDesc = GetCellValue(materiaRow, "Descripcion");

            var mensaje =
                $"Alumno: {nombre} {apellido} (Legajo: {legajo})\nFecha Nac.: {fechaNac}\n\n" +
                $"Materia: {mNombre} (Id: {mId})\nDescripción: {mDesc}";

            MessageBox.Show(mensaje, "Detalle seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Muestra el mensaje con la fila seleccionada de cada tabla
            MostrarSeleccionAlumnoYMateria();

            // Si además quiere abrir la ventana de materias:
            EditarMaterias ventana = new EditarMaterias();
            ventana.Show(); // o ShowDialog() según necesite
        }

        private void dtp_FechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }



        private void textB_materia_TextChanged(object sender, EventArgs e)
        {

        }
        private readonly MateriaService _materiaService;



        private async Task CargarMateriasAsync()
        {
            if (_materiaService == null)
            {
                MessageBox.Show("Servicio de materias no inicializado.");
                return;
            }

            List<Materia> materias;
            try
            {
                materias = await _materiaService.ObtenerMateriasAsync() ?? new List<Materia>();
            }
            catch (System.Net.Http.HttpRequestException hre)
            {
                // Mensaje claro para el caso de "conexión denegada"
                MessageBox.Show("No se pudo conectar con el servidor en http://localhost:5134. " +
                                "Asegúrese de que la API esté en ejecución y que el puerto/protocolo coincidan.\n\nDetalle: " + hre.Message,
                                "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                materias = new List<Materia>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener materias: " + ex.Message);
                materias = new List<Materia>();
            }

            if (Dgv_materias == null)
            {
                MessageBox.Show("Control de materias no disponible.");
                return;
            }

            Dgv_materias.DataSource = materias;

            if (Dgv_materias.Columns.Contains("Id"))
                Dgv_materias.Columns["Id"].HeaderText = "Código";
            if (Dgv_materias.Columns.Contains("Nombre"))
                Dgv_materias.Columns["Nombre"].HeaderText = "Materia";
            if (Dgv_materias.Columns.Contains("Descripcion"))
                Dgv_materias.Columns["Descripcion"].HeaderText = "Descripción";
        }

        private void Dgv_materias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        // Agregar el manejador en la clase Registro (puede ubicarse cerca de otros manejadores)
        private void btn_MostrarSeleccion_Click(object sender, EventArgs e)
        {
            MostrarSeleccionAlumnoYMateria();
        }
    }
}
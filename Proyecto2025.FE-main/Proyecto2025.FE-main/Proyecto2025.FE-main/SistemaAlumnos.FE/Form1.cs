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
        private readonly MateriaService _materiaService;

        public Registro()
        {
            InitializeComponent();

            // Fuente 
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.BackColor = Color.WhiteSmoke;

            ConfigurarDataGridView();

            // Botones estilizados con hover
            EstilizarBoton(btn_Agregaralumno, Color.MediumSeaGreen);
            EstilizarBoton(btn_Actualizar, Color.SteelBlue);
            EstilizarBoton(btn_Eliminar, Color.IndianRed);
            EstilizarBoton(btn_elimmateria, Color.IndianRed);

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

            // Conectar botón/textboxes de "agregar materia" si existen (evita dependencias del Designer)
            var foundBtn = this.Controls.Find("btn_agregarmateria", true);
            if (foundBtn.Length > 0 && foundBtn[0] is Button btnAgregarMateria)
            {
                EstilizarBoton(btnAgregarMateria, Color.MediumSeaGreen);
                btnAgregarMateria.Click += async (s, e) => await AgregarMateriaDesdeTextBoxesAsync();
            }

            var foundTbMat = this.Controls.Find("textB_agregarmateria", true);
            if (foundTbMat.Length > 0 && foundTbMat[0] is TextBox tbMat)
            {
                tbMat.KeyDown += async (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        e.SuppressKeyPress = true;
                        await AgregarMateriaDesdeTextBoxesAsync();
                    }
                };
            }

            var foundTbDesc = this.Controls.Find("textb_agregDescripcion", true);
            if (foundTbDesc.Length > 0 && foundTbDesc[0] is TextBox tbDesc)
            {
                tbDesc.KeyDown += async (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        e.SuppressKeyPress = true;
                        await AgregarMateriaDesdeTextBoxesAsync();
                    }
                };
            }

            // Asegurar que el botón de eliminar materia esté conectado al manejador
            if (btn_elimmateria != null)
            {
                // evitar doble suscripción
                btn_elimmateria.Click -= btn_elimmateria_Click;
                btn_elimmateria.Click += btn_elimmateria_Click;
            }

            // Al final del constructor 'Registro()', añadir la suscripción segura al botón btn_relacionar
            if (btn_relacionar != null)
            {
                btn_relacionar.Click -= btn_relacionar_Click;
                btn_relacionar.Click += btn_relacionar_Click;
            }

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

            // Configuración mínima para el DataGridView de materias (si existe)
            if (Dgv_materias != null)
            {
                Dgv_materias.ReadOnly = true;
                Dgv_materias.AllowUserToAddRows = false;
                Dgv_materias.AllowUserToDeleteRows = false;
                Dgv_materias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Dgv_materias.MultiSelect = false;
                Dgv_materias.BackgroundColor = Color.White;
                Dgv_materias.BorderStyle = BorderStyle.None;
                Dgv_materias.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
                Dgv_materias.DefaultCellStyle.SelectionForeColor = Color.White;
                Dgv_materias.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
                Dgv_materias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                Dgv_materias.EnableHeadersVisualStyles = false;
                Dgv_materias.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                Dgv_materias.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Dgv_materias.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                Dgv_materias.RowTemplate.Height = 28;
                Dgv_materias.GridColor = Color.LightGray;
            }
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
            ConfigurarPlaceholder(txt_Nombre, "Ingreso nombre...");
            ConfigurarPlaceholder(txt_Apellido, "Ingreso apellido...");
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
                btn_Actualizar.Enabled = true;
            }
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

        private void btn_MostrarSeleccion_Click(object sender, EventArgs e)
        {
            MostrarSeleccionAlumnoYMateria();
        }

        // Eliminación de materia vinculada al botón visible btn_elimmateria
        private async void btn_elimmateria_Click(object sender, EventArgs e)
        {
            if (_materiaService == null)
            {
                MessageBox.Show("Servicio de materias no inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var row = Dgv_materias?.CurrentRow;
            if (row == null)
            {
                MessageBox.Show("Seleccione una materia para eliminar.", "Selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object? idObj = null;
            if (Dgv_materias?.Columns != null && Dgv_materias.Columns.Contains("Id"))
            {
                idObj = row.Cells["Id"]?.Value;
            }
            else if (row.Cells.Count > 0)
            {
                idObj = row.Cells[0]?.Value;
            }

            if (idObj == null || !int.TryParse(idObj.ToString(), out int id))
            {
                MessageBox.Show("No se pudo obtener el Id de la materia seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var nombre = Dgv_materias.Columns.Contains("Nombre") ? row.Cells["Nombre"]?.Value?.ToString() ?? "" : "";

            var confirm = MessageBox.Show($"¿Confirma eliminar la materia '{nombre}' (Id: {id})?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                bool exito = await _materiaService.EliminarMateriaAsync(id);
                MessageBox.Show(exito ? "Materia eliminada correctamente." : "Error al eliminar materia.", "Resultado", MessageBoxButtons.OK, exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar materia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            await CargarMateriasAsync();
        }

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textb_agregDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        // Nuevo método: agrega materia usando textboxes y el servicio existente.
        private async Task AgregarMateriaDesdeTextBoxesAsync()
        {
            if (_materiaService == null)
            {
                MessageBox.Show("Servicio de materias no inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var foundTbMat = this.Controls.Find("textB_agregarmateria", true);
            var foundTbDesc = this.Controls.Find("textb_agregDescripcion", true);

            var nombre = (foundTbMat.Length > 0 && foundTbMat[0] is TextBox tbMat) ? tbMat.Text.Trim() : string.Empty;
            var descripcion = (foundTbDesc.Length > 0 && foundTbDesc[0] is TextBox tbDesc) ? tbDesc.Text.Trim() : string.Empty;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Materia y descripción son obligatorios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var materia = new Materia
            {
                Nombre = nombre,
                Descripcion = descripcion
            };

            bool exito;
            try
            {
                exito = await _materiaService.AgregarMateriaAsync(materia);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar materia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(exito ? "Materia agregada correctamente." : "Error al agregar materia.", "Resultado",
                MessageBoxButtons.OK, exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            await CargarMateriasAsync();

            if (foundTbMat.Length > 0 && foundTbMat[0] is TextBox tbMatClear) tbMatClear.Text = "";
            if (foundTbDesc.Length > 0 && foundTbDesc[0] is TextBox tbDescClear) tbDescClear.Text = "";
        }

        // Nuevo manejador in Form1 (Registro)
        private void btn_relacionar_Click(object sender, EventArgs e)
        {
            var alumnoRow = dgv_Alumnos?.CurrentRow;
            var materiaRow = Dgv_materias?.CurrentRow;

            if (alumnoRow == null || materiaRow == null)
            {
                MessageBox.Show("Seleccione un alumno y una materia antes de relacionarlos.", "Selección incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var alumno = new Alumno
            {
                Id = alumnoRow.Cells["Id"]?.Value is int ai ? ai : Convert.ToInt32(alumnoRow.Cells[0].Value),
                Nombre = alumnoRow.Cells["Nombre"]?.Value?.ToString() ?? "",
                Apellido = alumnoRow.Cells["Apellido"]?.Value?.ToString() ?? "",
                Legajo = alumnoRow.Cells["Legajo"]?.Value?.ToString() ?? "",
                FechaNacimiento = alumnoRow.Cells["FechaNacimiento"]?.Value is DateTime dt ? dt : DateTime.MinValue
            };

            var materia = new Materia
            {
                Id = materiaRow.Cells["Id"]?.Value is int mi ? mi : Convert.ToInt32(materiaRow.Cells[0].Value),
                Nombre = materiaRow.Cells["Nombre"]?.Value?.ToString() ?? "",
                Descripcion = materiaRow.Cells["Descripcion"]?.Value?.ToString() ?? ""
            };

            var frm = new EditarMaterias(alumno, materia);
            frm.ShowDialog();
        }
    }
}
using SistemaAlumnos.FE.Models;
using System;
using System.Windows.Forms;

namespace SistemaAlumnos.FE
{
    public partial class EditarMaterias : Form
    {
        public EditarMaterias()
        {
            InitializeComponent();
        }

        // Nuevo constructor que recibe los datos y muestra el mensaje dentro de un Label en el formulario
        public EditarMaterias(Alumno alumno, Materia materia) : this()
        {

            var mensaje = $"¡Felicitaciones! El alumno {alumno.Nombre} + {alumno.Apellido} + se inscribió a la materia {materia.Nombre} con éxito.";

            // Buscar un Label existente llamado "lblMensaje"
            var found = this.Controls.Find("lblMensaje", true).FirstOrDefault() as Label;

            if (found == null)
            {
                // Si no existe, crear uno y añadirlo al formulario (arriba)
                found = new Label
                {
                    Name = "lblMensaje",
                    AutoSize = false,
                    Height = 60,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(8),
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    ForeColor = SystemColors.ControlText,
                    BackColor = SystemColors.Control
                };

                this.Controls.Add(found);
                found.BringToFront();
            }

            // Asignar el texto al Label
            found.Text = mensaje;
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // EditarMaterias
            // 
            ClientSize = new Size(309, 253);
            Name = "EditarMaterias";
            Load += EditarMaterias_Load;
            ResumeLayout(false);
          
        }

        private void EditarMaterias_Load(object sender, EventArgs e)
        {

        }
    }
}
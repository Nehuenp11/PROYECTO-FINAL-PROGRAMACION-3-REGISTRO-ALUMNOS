using System;
using System.Windows.Forms;

namespace SistemaAlumnos.FE
{
    public partial class MostrarResultado : Form
    {
        public MostrarResultado()
        {
            InitializeComponent();
        }

        public MostrarResultado(string mensaje) : this()
        {
            SetMessage(mensaje);
        }

        public void SetMessage(string mensaje)
        {
            lblMensaje.Text = mensaje ?? string.Empty;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
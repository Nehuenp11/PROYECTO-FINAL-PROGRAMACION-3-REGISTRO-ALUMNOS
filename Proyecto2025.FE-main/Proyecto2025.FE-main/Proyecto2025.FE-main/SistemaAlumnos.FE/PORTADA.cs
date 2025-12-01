using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SistemaAlumnos.FE
{
    public partial class PORTADA : Form
    {
        public PORTADA()
        {
            InitializeComponent();
        }

        private void bTN_acceder_Click(object sender, EventArgs e)
        {
            Registro ventana = new Registro();
            ventana.Show();   // abre el formulario Registro
            this.Hide();      // oculta la portada (opcional)
        }

     
    }
}

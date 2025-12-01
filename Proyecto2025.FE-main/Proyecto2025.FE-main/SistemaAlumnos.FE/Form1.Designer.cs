namespace SistemaAlumnos.FE
{
    partial class Registro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            txt_Legajo = new TextBox();
            dtp_FechaNac = new DateTimePicker();
            btn_Agregaralumno = new Button();
            dgv_Alumnos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_Actualizar = new Button();
            btn_Eliminar = new Button();
            btn_salir = new Button();
            Dgv_materias = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            byn_eliminarmateria = new Button();
            btn_agregarmateria = new Button();
            btn_MostrarSeleccion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Alumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_materias).BeginInit();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(88, 23);
            txt_Nombre.Margin = new Padding(3, 4, 3, 4);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(228, 27);
            txt_Nombre.TabIndex = 0;
            txt_Nombre.TextChanged += txt_Nombre_TextChanged;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(88, 62);
            txt_Apellido.Margin = new Padding(3, 4, 3, 4);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(228, 27);
            txt_Apellido.TabIndex = 1;
            // 
            // txt_Legajo
            // 
            txt_Legajo.Location = new Point(88, 100);
            txt_Legajo.Margin = new Padding(3, 4, 3, 4);
            txt_Legajo.Name = "txt_Legajo";
            txt_Legajo.Size = new Size(228, 27);
            txt_Legajo.TabIndex = 2;
            // 
            // dtp_FechaNac
            // 
            dtp_FechaNac.Location = new Point(98, 139);
            dtp_FechaNac.Margin = new Padding(3, 4, 3, 4);
            dtp_FechaNac.Name = "dtp_FechaNac";
            dtp_FechaNac.Size = new Size(228, 27);
            dtp_FechaNac.TabIndex = 3;
            dtp_FechaNac.ValueChanged += dtp_FechaNac_ValueChanged;
            // 
            // btn_Agregaralumno
            // 
            btn_Agregaralumno.Location = new Point(12, 199);
            btn_Agregaralumno.Margin = new Padding(3, 4, 3, 4);
            btn_Agregaralumno.Name = "btn_Agregaralumno";
            btn_Agregaralumno.Size = new Size(198, 31);
            btn_Agregaralumno.TabIndex = 4;
            btn_Agregaralumno.Text = "Agregar Alumno";
            btn_Agregaralumno.UseVisualStyleBackColor = true;
            btn_Agregaralumno.Click += btnAgregar_Click;
            // 
            // dgv_Alumnos
            // 
            dgv_Alumnos.AllowDrop = true;
            dgv_Alumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Alumnos.Location = new Point(343, 33);
            dgv_Alumnos.Margin = new Padding(3, 4, 3, 4);
            dgv_Alumnos.Name = "dgv_Alumnos";
            dgv_Alumnos.RowHeadersWidth = 51;
            dgv_Alumnos.Size = new Size(685, 197);
            dgv_Alumnos.TabIndex = 3;
            dgv_Alumnos.CellClick += dgvAlumnos_CellClick;
            dgv_Alumnos.CellContentClick += dgv_Alumnos_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Legajo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 139);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 4;
            label4.Text = "Fecha Nac.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 305);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 4;
            label5.Text = "listado de materias";
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.Location = new Point(12, 238);
            btn_Actualizar.Margin = new Padding(3, 4, 3, 4);
            btn_Actualizar.Name = "btn_Actualizar";
            btn_Actualizar.Size = new Size(198, 31);
            btn_Actualizar.TabIndex = 5;
            btn_Actualizar.Text = "Actualizar ";
            btn_Actualizar.UseVisualStyleBackColor = true;
            btn_Actualizar.Click += btnActualizar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(12, 277);
            btn_Eliminar.Margin = new Padding(3, 4, 3, 4);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(198, 31);
            btn_Eliminar.TabIndex = 6;
            btn_Eliminar.Text = "Eliminar ";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btnEliminar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Anchor = AnchorStyles.None;
            btn_salir.AutoSize = true;
            btn_salir.Location = new Point(24, 504);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(147, 30);
            btn_salir.TabIndex = 7;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            // 
            // Dgv_materias
            // 
            Dgv_materias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_materias.Location = new Point(343, 328);
            Dgv_materias.Name = "Dgv_materias";
            Dgv_materias.RowHeadersWidth = 51;
            Dgv_materias.Size = new Size(685, 160);
            Dgv_materias.TabIndex = 8;
            Dgv_materias.CellContentClick += Dgv_materias_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(435, 9);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 9;
            label6.Text = "Listado de  alumnos:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 340);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 11;
            // 
            // byn_eliminarmateria
            // 
            byn_eliminarmateria.Location = new Point(1051, 398);
            byn_eliminarmateria.Margin = new Padding(3, 4, 3, 4);
            byn_eliminarmateria.Name = "byn_eliminarmateria";
            byn_eliminarmateria.Size = new Size(198, 31);
            byn_eliminarmateria.TabIndex = 14;
            byn_eliminarmateria.Text = "Eliminar materia";
            byn_eliminarmateria.UseVisualStyleBackColor = true;
            // 
            // btn_agregarmateria
            // 
            btn_agregarmateria.Location = new Point(1051, 359);
            btn_agregarmateria.Margin = new Padding(3, 4, 3, 4);
            btn_agregarmateria.Name = "btn_agregarmateria";
            btn_agregarmateria.Size = new Size(198, 31);
            btn_agregarmateria.TabIndex = 12;
            btn_agregarmateria.Text = "Agregar meteria";
            btn_agregarmateria.UseVisualStyleBackColor = true;
            // 
            // btn_MostrarSeleccion
            // 
            btn_MostrarSeleccion.Location = new Point(343, 238);
            btn_MostrarSeleccion.Margin = new Padding(3, 4, 3, 4);
            btn_MostrarSeleccion.Name = "btn_MostrarSeleccion";
            btn_MostrarSeleccion.Size = new Size(198, 31);
            btn_MostrarSeleccion.TabIndex = 21;
            btn_MostrarSeleccion.Text = "Mostrar Selección";
            btn_MostrarSeleccion.UseVisualStyleBackColor = true;
            btn_MostrarSeleccion.Click += btn_MostrarSeleccion_Click;
            // 
            // Registro
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1382, 559);
            Controls.Add(btn_MostrarSeleccion);
            Controls.Add(byn_eliminarmateria);
            Controls.Add(btn_agregarmateria);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Dgv_materias);
            Controls.Add(btn_salir);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Actualizar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_Alumnos);
            Controls.Add(btn_Agregaralumno);
            Controls.Add(dtp_FechaNac);
            Controls.Add(txt_Legajo);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registro";
            Load += Registro_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Alumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_materias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_Legajo;
        private DateTimePicker dtp_FechaNac;
        private Button btn_Agregaralumno;
        private DataGridView dgv_Alumnos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_Actualizar;
        private Button btn_Eliminar;
        private Button btn_salir;
        private DataGridView Dgv_materias;
        private Label label6;
        private Label label7;
        private Button byn_eliminarmateria;
        private Button btn_agregarmateria;
        private Button btn_MostrarSeleccion;
    }
}

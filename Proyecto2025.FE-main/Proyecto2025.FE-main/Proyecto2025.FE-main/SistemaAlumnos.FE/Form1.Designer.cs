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
            btn_agregarmateria = new Button();
            btn_relacionar = new Button();
            btn_elimmateria = new Button();
            btn_EliminarMateria = new Button();
            label8 = new Label();
            label9 = new Label();
            textb_agregDescripcion = new TextBox();
            textB_agregarmateria = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Alumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_materias).BeginInit();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(109, 23);
            txt_Nombre.Margin = new Padding(3, 4, 3, 4);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(228, 27);
            txt_Nombre.TabIndex = 0;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(109, 61);
            txt_Apellido.Margin = new Padding(3, 4, 3, 4);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(228, 27);
            txt_Apellido.TabIndex = 1;
            // 
            // txt_Legajo
            // 
            txt_Legajo.Location = new Point(109, 100);
            txt_Legajo.Margin = new Padding(3, 4, 3, 4);
            txt_Legajo.Name = "txt_Legajo";
            txt_Legajo.Size = new Size(228, 27);
            txt_Legajo.TabIndex = 2;
            // 
            // dtp_FechaNac
            // 
            dtp_FechaNac.Location = new Point(109, 150);
            dtp_FechaNac.Margin = new Padding(3, 4, 3, 4);
            dtp_FechaNac.Name = "dtp_FechaNac";
            dtp_FechaNac.Size = new Size(228, 27);
            dtp_FechaNac.TabIndex = 3;
            // 
            // btn_Agregaralumno
            // 
            btn_Agregaralumno.Location = new Point(1117, 33);
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
            dgv_Alumnos.Location = new Point(375, 33);
            dgv_Alumnos.Margin = new Padding(3, 4, 3, 4);
            dgv_Alumnos.Name = "dgv_Alumnos";
            dgv_Alumnos.RowHeadersWidth = 51;
            dgv_Alumnos.Size = new Size(706, 197);
            dgv_Alumnos.TabIndex = 3;
            dgv_Alumnos.CellClick += dgvAlumnos_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
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
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 4;
            label4.Text = "Fecha Nac.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(375, 305);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 4;
            label5.Text = "listado de materias";
            label5.Click += label5_Click;
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.Location = new Point(1117, 72);
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
            btn_Eliminar.Location = new Point(1117, 111);
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
            btn_salir.Location = new Point(12, 504);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(147, 30);
            btn_salir.TabIndex = 7;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            // 
            // Dgv_materias
            // 
            Dgv_materias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_materias.Location = new Point(375, 328);
            Dgv_materias.Name = "Dgv_materias";
            Dgv_materias.RowHeadersWidth = 51;
            Dgv_materias.Size = new Size(706, 206);
            Dgv_materias.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(375, 9);
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
            // btn_agregarmateria
            // 
            btn_agregarmateria.Location = new Point(1117, 409);
            btn_agregarmateria.Margin = new Padding(3, 4, 3, 4);
            btn_agregarmateria.Name = "btn_agregarmateria";
            btn_agregarmateria.Size = new Size(198, 31);
            btn_agregarmateria.TabIndex = 12;
            btn_agregarmateria.Text = "Agregar meteria";
            btn_agregarmateria.UseVisualStyleBackColor = true;
            // 
            // btn_relacionar
            // 
            btn_relacionar.Location = new Point(12, 466);
            btn_relacionar.Margin = new Padding(3, 4, 3, 4);
            btn_relacionar.Name = "btn_relacionar";
            btn_relacionar.Size = new Size(198, 31);
            btn_relacionar.TabIndex = 21;
            btn_relacionar.Text = "Inscribir";
            btn_relacionar.UseVisualStyleBackColor = true;
            btn_relacionar.Click += btn_MostrarSeleccion_Click;
            // 
            // btn_elimmateria
            // 
            btn_elimmateria.Location = new Point(1117, 448);
            btn_elimmateria.Margin = new Padding(3, 4, 3, 4);
            btn_elimmateria.Name = "btn_elimmateria";
            btn_elimmateria.Size = new Size(198, 31);
            btn_elimmateria.TabIndex = 22;
            btn_elimmateria.Text = "eliminar materia";
            btn_elimmateria.UseVisualStyleBackColor = true;
            // 
            // btn_EliminarMateria
            // 
            btn_EliminarMateria.Location = new Point(1051, 400);
            btn_EliminarMateria.Margin = new Padding(3, 4, 3, 4);
            btn_EliminarMateria.Name = "btn_EliminarMateria";
            btn_EliminarMateria.Size = new Size(198, 31);
            btn_EliminarMateria.TabIndex = 13;
            btn_EliminarMateria.Text = "Eliminar materia";
            btn_EliminarMateria.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(-3, 379);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 25;
            label8.Text = "descripcion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 340);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 26;
            label9.Text = "materia";
            // 
            // textb_agregDescripcion
            // 
            textb_agregDescripcion.Location = new Point(98, 379);
            textb_agregDescripcion.Margin = new Padding(3, 4, 3, 4);
            textb_agregDescripcion.Name = "textb_agregDescripcion";
            textb_agregDescripcion.Size = new Size(228, 27);
            textb_agregDescripcion.TabIndex = 24;
            textb_agregDescripcion.TextChanged += textb_agregDescripcion_TextChanged;
            // 
            // textB_agregarmateria
            // 
            textB_agregarmateria.Location = new Point(98, 344);
            textB_agregarmateria.Margin = new Padding(3, 4, 3, 4);
            textB_agregarmateria.Name = "textB_agregarmateria";
            textB_agregarmateria.Size = new Size(228, 27);
            textB_agregarmateria.TabIndex = 23;
            // 
            // Registro
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1382, 559);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textb_agregDescripcion);
            Controls.Add(textB_agregarmateria);
            Controls.Add(btn_elimmateria);
            Controls.Add(btn_relacionar);
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
        private Button btn_agregarmateria;
        private Button btn_EliminarMateria;
        private Button btn_relacionar;
        private Button btn_elimmateria;

        private Label label8;
        private Label label9;
        private TextBox textb_agregDescripcion;
        private TextBox textB_agregarmateria;
    }
}

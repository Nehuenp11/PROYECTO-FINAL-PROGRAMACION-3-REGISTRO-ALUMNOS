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
            ((System.ComponentModel.ISupportInitialize)dgv_Alumnos).BeginInit();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(118, 16);
            txt_Nombre.Margin = new Padding(3, 4, 3, 4);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(228, 27);
            txt_Nombre.TabIndex = 0;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(118, 55);
            txt_Apellido.Margin = new Padding(3, 4, 3, 4);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(228, 27);
            txt_Apellido.TabIndex = 1;
            // 
            // txt_Legajo
            // 
            txt_Legajo.Location = new Point(118, 93);
            txt_Legajo.Margin = new Padding(3, 4, 3, 4);
            txt_Legajo.Name = "txt_Legajo";
            txt_Legajo.Size = new Size(228, 27);
            txt_Legajo.TabIndex = 2;
            // 
            // dtp_FechaNac
            // 
            dtp_FechaNac.Location = new Point(118, 132);
            dtp_FechaNac.Margin = new Padding(3, 4, 3, 4);
            dtp_FechaNac.Name = "dtp_FechaNac";
            dtp_FechaNac.Size = new Size(228, 27);
            dtp_FechaNac.TabIndex = 3;
            // 
            // btn_Agregaralumno
            // 
            btn_Agregaralumno.Location = new Point(24, 252);
            btn_Agregaralumno.Margin = new Padding(3, 4, 3, 4);
            btn_Agregaralumno.Name = "btn_Agregaralumno";
            btn_Agregaralumno.Size = new Size(142, 31);
            btn_Agregaralumno.TabIndex = 4;
            btn_Agregaralumno.Text = "Agregar Alumno";
            btn_Agregaralumno.UseVisualStyleBackColor = true;
            btn_Agregaralumno.Click += btnAgregar_Click;
            // 
            // dgv_Alumnos
            // 
            dgv_Alumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Alumnos.Location = new Point(392, 20);
            dgv_Alumnos.Margin = new Padding(3, 4, 3, 4);
            dgv_Alumnos.Name = "dgv_Alumnos";
            dgv_Alumnos.RowHeadersWidth = 51;
            dgv_Alumnos.Size = new Size(384, 399);
            dgv_Alumnos.TabIndex = 3;
            dgv_Alumnos.CellClick += dgvAlumnos_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 59);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 97);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Legajo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 140);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 4;
            label4.Text = "Fecha Nac.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 209);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Listado";
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.Location = new Point(24, 291);
            btn_Actualizar.Margin = new Padding(3, 4, 3, 4);
            btn_Actualizar.Name = "btn_Actualizar";
            btn_Actualizar.Size = new Size(198, 31);
            btn_Actualizar.TabIndex = 5;
            btn_Actualizar.Text = "Actualizar Seleccionado";
            btn_Actualizar.UseVisualStyleBackColor = true;
            btn_Actualizar.Click += btnActualizar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(24, 330);
            btn_Eliminar.Margin = new Padding(3, 4, 3, 4);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(179, 31);
            btn_Eliminar.TabIndex = 6;
            btn_Eliminar.Text = "Eliminar Seleccionado";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btnEliminar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(24, 381);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(147, 29);
            btn_salir.TabIndex = 7;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
 
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(799, 459);
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
            Text = "Registro Alumnos";
            ((System.ComponentModel.ISupportInitialize)dgv_Alumnos).EndInit();
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
    }
}

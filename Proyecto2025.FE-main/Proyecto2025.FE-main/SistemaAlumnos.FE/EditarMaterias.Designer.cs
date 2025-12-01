namespace SistemaAlumnos.FE
{
    partial class EditarMaterias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtb_agregarmateria = new TextBox();
            btn_agregarmateria = new Button();
            listB_verlistaactual = new ListBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtb_agregarmateria
            // 
            txtb_agregarmateria.Location = new Point(23, 59);
            txtb_agregarmateria.Name = "txtb_agregarmateria";
            txtb_agregarmateria.Size = new Size(149, 27);
            txtb_agregarmateria.TabIndex = 0;
            txtb_agregarmateria.TextChanged += textBox1_TextChanged;
            // 
            // btn_agregarmateria
            // 
            btn_agregarmateria.Location = new Point(12, 118);
            btn_agregarmateria.Name = "btn_agregarmateria";
            btn_agregarmateria.Size = new Size(171, 29);
            btn_agregarmateria.TabIndex = 1;
            btn_agregarmateria.Text = "agregar materia";
            btn_agregarmateria.UseVisualStyleBackColor = true;
            // 
            // listB_verlistaactual
            // 
            listB_verlistaactual.FormattingEnabled = true;
            listB_verlistaactual.Location = new Point(200, 118);
            listB_verlistaactual.Name = "listB_verlistaactual";
            listB_verlistaactual.Size = new Size(150, 284);
            listB_verlistaactual.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(264, 20);
            label1.TabIndex = 3;
            label1.Text = "Escribir nombre de materia a agregar: ";
            // 
            // button1
            // 
            button1.Location = new Point(12, 164);
            button1.Name = "button1";
            button1.Size = new Size(171, 29);
            button1.TabIndex = 4;
            button1.Text = "eliminar materia";
            button1.UseVisualStyleBackColor = true;
            // 
            // EditarMaterias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 469);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listB_verlistaactual);
            Controls.Add(btn_agregarmateria);
            Controls.Add(txtb_agregarmateria);
            Name = "EditarMaterias";
            Text = "EditarMaterias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtb_agregarmateria;
        private Button btn_agregarmateria;
        private ListBox listB_verlistaactual;
        private Label label1;
        private Button button1;
    }
}
namespace SistemaAlumnos.FE
{
    partial class PORTADA
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PORTADA));
            bTN_acceder = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // bTN_acceder
            // 
            bTN_acceder.Image = (Image)resources.GetObject("bTN_acceder.Image");
            bTN_acceder.ImageAlign = ContentAlignment.TopLeft;
            bTN_acceder.Location = new Point(0, 0);
            bTN_acceder.Name = "bTN_acceder";
            bTN_acceder.Size = new Size(1043, 477);
            bTN_acceder.TabIndex = 0;
            bTN_acceder.UseVisualStyleBackColor = true;
            bTN_acceder.Click += bTN_acceder_Click;
            // 
            // toolTip1
            // 
            // 
            // PORTADA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 480);
            Controls.Add(bTN_acceder);
            Name = "PORTADA";
            Text = "PEREZ-FREDES-LASALA";
            ResumeLayout(false);
        }

        #endregion

        private Button bTN_acceder;
        private ToolTip toolTip1;
    }
}
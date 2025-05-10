namespace Parcial_II
{
    partial class Form1
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
            btnCargarCSV = new Button();
            btnMostrarAprobados = new Button();
            btnMostrarReprobados = new Button();
            lstAprobados = new ListBox();
            lstReprobados = new ListBox();
            SuspendLayout();
            // 
            // btnCargarCSV
            // 
            btnCargarCSV.Location = new Point(41, 12);
            btnCargarCSV.Name = "btnCargarCSV";
            btnCargarCSV.Size = new Size(226, 102);
            btnCargarCSV.TabIndex = 0;
            btnCargarCSV.Text = "Cargar informacion";
            btnCargarCSV.UseVisualStyleBackColor = true;
            btnCargarCSV.Click += btnCargarCSV_Click;
            // 
            // btnMostrarAprobados
            // 
            btnMostrarAprobados.Location = new Point(41, 131);
            btnMostrarAprobados.Name = "btnMostrarAprobados";
            btnMostrarAprobados.Size = new Size(226, 102);
            btnMostrarAprobados.TabIndex = 1;
            btnMostrarAprobados.Text = "\tMostrar estudiantes aprobados";
            btnMostrarAprobados.UseVisualStyleBackColor = true;
            btnMostrarAprobados.Click += btnMostrarAprobados_Click;
            // 
            // btnMostrarReprobados
            // 
            btnMostrarReprobados.Location = new Point(487, 131);
            btnMostrarReprobados.Name = "btnMostrarReprobados";
            btnMostrarReprobados.Size = new Size(226, 102);
            btnMostrarReprobados.TabIndex = 2;
            btnMostrarReprobados.Text = "Mostrar estudiantes reprobados";
            btnMostrarReprobados.UseVisualStyleBackColor = true;
            btnMostrarReprobados.Click += btnMostrarReprobados_Click;
            // 
            // lstAprobados
            // 
            lstAprobados.FormattingEnabled = true;
            lstAprobados.Location = new Point(41, 254);
            lstAprobados.Name = "lstAprobados";
            lstAprobados.Size = new Size(197, 184);
            lstAprobados.TabIndex = 3;
            // 
            // lstReprobados
            // 
            lstReprobados.FormattingEnabled = true;
            lstReprobados.Location = new Point(487, 254);
            lstReprobados.Name = "lstReprobados";
            lstReprobados.Size = new Size(197, 184);
            lstReprobados.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstReprobados);
            Controls.Add(lstAprobados);
            Controls.Add(btnMostrarReprobados);
            Controls.Add(btnMostrarAprobados);
            Controls.Add(btnCargarCSV);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargarCSV;
        private Button btnMostrarAprobados;
        private Button btnMostrarReprobados;
        private ListBox lstAprobados;
        private ListBox lstReprobados;
    }
}

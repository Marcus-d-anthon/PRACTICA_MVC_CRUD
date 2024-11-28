namespace ACADEMICO_ISTLC.Vista
{
    partial class frmEstudiante
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
            panel1 = new Panel();
            grdEstudiantes = new DataGridView();
            panel2 = new Panel();
            btnNuevo = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdEstudiantes).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(grdEstudiantes);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 218);
            panel1.TabIndex = 0;
            // 
            // grdEstudiantes
            // 
            grdEstudiantes.AllowUserToAddRows = false;
            grdEstudiantes.AllowUserToDeleteRows = false;
            grdEstudiantes.AllowUserToResizeColumns = false;
            grdEstudiantes.AllowUserToResizeRows = false;
            grdEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdEstudiantes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdEstudiantes.Dock = DockStyle.Fill;
            grdEstudiantes.Location = new Point(0, 0);
            grdEstudiantes.Name = "grdEstudiantes";
            grdEstudiantes.ReadOnly = true;
            grdEstudiantes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grdEstudiantes.Size = new Size(657, 218);
            grdEstudiantes.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNuevo);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 218);
            panel2.Name = "panel2";
            panel2.Size = new Size(657, 45);
            panel2.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.Dock = DockStyle.Right;
            btnNuevo.Location = new Point(257, 0);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 45);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnModificar
            // 
            btnModificar.Dock = DockStyle.Right;
            btnModificar.Location = new Point(357, 0);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 45);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Dock = DockStyle.Right;
            btnEliminar.Location = new Point(457, 0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 45);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.Location = new Point(557, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 45);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 263);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEstudiante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEstudiante";
            Load += frmEstudiante_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdEstudiantes).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView grdEstudiantes;
        private Panel panel2;
        private Button btnNuevo;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}
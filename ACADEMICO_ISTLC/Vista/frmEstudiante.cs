using ACADEMICO_ISTLC.Controlador.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACADEMICO_ISTLC.Vista
{
    public partial class frmEstudiante : Form
    {
        public frmEstudiante()
        {
            InitializeComponent();
        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            EstudianteBuildingAccess objEstudianteBL = new EstudianteBuildingAccess();
            grdEstudiantes.DataSource = objEstudianteBL.GetEstudiantesBL();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmModificarEstudiante formularioModificar = new frmModificarEstudiante();
            formularioModificar.tipo = "N";
            formularioModificar.ShowDialog();
        }
    }
}

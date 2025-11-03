using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivoEquipo13.Forms
{
    public partial class frmCarnetSocio : Form
    {
        public frmCarnetSocio(string nombre, string apellido, string dni, string idSocio, string vencimiento)
        {
            InitializeComponent();
            lblNombreCompleto.Text = nombre + " " + apellido;
            lblDni.Text = dni;
            lblIdSocio.Text = idSocio;
            lblVencimieto.Text = vencimiento;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Carnet Impreso", "Imprimir Carnet", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cerrar el formulario después de imprimir
            this.Close();
        }
    }
}

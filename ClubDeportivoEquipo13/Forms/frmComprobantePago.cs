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
    public partial class frmComprobantePago : Form
    {
        public frmComprobantePago(string nombre, string apellido, string dni, string monto, string forma, string fecha, string vencimiento = "")
        {
            InitializeComponent();

            lblNombreCompleto.Text = nombre + " " + apellido;
            lblDni.Text = dni;
            lblMontoAbonado.Text = "$ " + monto;
            lblFechaPago.Text = fecha;
            lblFormaPago.Text = forma;

            if (string.IsNullOrEmpty(vencimiento))
            {
                lblTituloValido.Visible = false;
                lblFechaValido.Visible = false;
            }
            else 
            {
                lblFechaValido.Text = vencimiento;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comprobante Impreso", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}

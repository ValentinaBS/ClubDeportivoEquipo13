using ClubDeportivoEquipo13.Datos;
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
    public partial class frmMenu : Form
    {
        internal string usuario;
        internal string rol;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Usuario: {usuario} ({rol})";
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscripcion inscripcion = new frmInscripcion();
            inscripcion.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            frmPagarCuota pagarCuota = new frmPagarCuota();
            pagarCuota.Show();
        }

        private void btnVencimientos_Click(object sender, EventArgs e)
        {
            frmVencimientos vencimientos = new frmVencimientos();
            vencimientos.Show();
        }
    }
}

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
    public partial class frmVencimientos : Form
    {
        private PersonasDatos _personasDatos;

        public frmVencimientos()
        {
            InitializeComponent();
            _personasDatos = new PersonasDatos();
            ConfigurarColumnasDataGridView();
            this.AcceptButton = btnGenerarListado;
            this.CancelButton = btnAceptar;
        }

        private void ConfigurarColumnasDataGridView()
        {
            Socio.DataPropertyName = "Socio";
            IdSocio.DataPropertyName = "IdSocio";
            FechaVencimiento.DataPropertyName = "FechaVencimiento";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnGenerarListado_Click(object sender, EventArgs e)
        {
            DateTime fechaConsulta = dtpFechaDeConsulta.Value;

            try
            {
                if (cboSoloDia.Checked)
                {
                    DataTable dtVencidosEseDia = _personasDatos.ListarSociosVencidosEseDia(fechaConsulta);
                    dataGridView1.DataSource = dtVencidosEseDia;

                    if (dtVencidosEseDia.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron socios con cuotas vencidas en esta fecha.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                } else
                {
                    DataTable dtVencidos = _personasDatos.ListarSociosVencidos(fechaConsulta);

                    dataGridView1.DataSource = dtVencidos;

                    if (dtVencidos.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron socios con cuotas vencidas a esta fecha.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el listado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

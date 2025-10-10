using ClubDeportivoEquipo13.Datos;
using ClubDeportivoEquipo13.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivoEquipo13.Forms
{
    public partial class frmCompletarInscripcion : Form
    {
        public int IdPersona; // Recibido desde frmInscripcion

        public frmCompletarInscripcion()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!rdoSocio.Checked && !rdoNoSocio.Checked)
            {
                MessageBox.Show("Debe seleccionar tipo de inscripción.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PersonasDatos datos = new PersonasDatos();
            string respuesta = "";

            try
            {
                if (rdoSocio.Checked)
                {
                    // Crear objeto Socio con la primera cuota mensual
                    Socio socio = new Socio
                    {
                        IdPersona = IdPersona,
                        FechaVencimiento = dtpFecha.Value,
                        Cuota = new CuotaMensual
                        {
                            Monto = Convert.ToDouble(txtMonto.Text),
                            FechaPago = DateTime.Now,
                            FechaVencimiento = dtpFecha.Value,
                            FormaPago = cboFormaPago.Text
                        }
                    };

                    respuesta = datos.NuevoSocio(socio);
                }
                else if (rdoNoSocio.Checked)
                {
                    // Crear objeto NoSocio con la primera cuota diaria
                    NoSocio noSocio = new NoSocio
                    {
                        IdPersona = IdPersona,
                        Cuota = new CuotaDiaria
                        {
                            Monto = Convert.ToDouble(txtMonto.Text),
                            FechaPago = DateTime.Now,
                            FormaPago = cboFormaPago.Text
                        }
                    };

                    respuesta = datos.NuevoNoSocio(noSocio);
                }

                // Validar respuesta
                if (int.TryParse(respuesta, out int codigo))
                {
                    if (codigo == 1)
                        MessageBox.Show("La persona ya está registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Registro exitoso con código: " + respuesta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Cierra el formulario sin crear instancias duplicadas
        }

        private void rdoSocio_CheckedChanged(object sender, EventArgs e)
        {
            // Muestra el selector de fecha
            lblFecha.Visible = true;
            dtpFecha.Visible = true;
        }

        private void cboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdoNoSocio_CheckedChanged(object sender, EventArgs e)
        {
            // Esconde el selector de fecha
            lblFecha.Visible = false;
            dtpFecha.Visible = false;
        }
    }
}

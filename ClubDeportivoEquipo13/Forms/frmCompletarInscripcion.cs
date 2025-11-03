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
            // Carga los enums
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            var values = Enum.GetValues(typeof(Datos.TiposDePago)).Cast<Datos.TiposDePago>();

            foreach (var value in values)
            {
                cboFormaPago.Items.Add(GetEnumDescription(value));
            }
        }

        private string GetEnumDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attr = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attr?.Description ?? value.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DateTime vencimientoCalc = dtpFecha.Value.Date.AddDays(30);
            if (!rdoSocio.Checked && !rdoNoSocio.Checked)
            {
                MessageBox.Show("Debe seleccionar tipo de inscripción.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PersonasDatos datos = new PersonasDatos();
            string respuesta = "";

            try
            {
                int idGenerado = 0;
                if (rdoSocio.Checked)
                {
                    // Crear objeto Socio con la primera cuota mensual
                    Socio socio = new Socio
                    {
                        IdPersona = IdPersona,
                        FechaVencimiento = vencimientoCalc,
                        Cuota = new CuotaMensual
                        {
                            Monto = Convert.ToDouble(txtMonto.Text),
                            FechaPago = DateTime.Now,
                            FechaVencimiento = vencimientoCalc,
                            FormaPago = cboFormaPago.Text
                        }
                    };

                    respuesta = datos.NuevoSocio(socio);
                    idGenerado = Convert.ToInt32(respuesta);
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
                    idGenerado = Convert.ToInt32(respuesta);
                }
                //validacion del ID generado
                if (idGenerado <= 0)
                {
                    MessageBox.Show("Error al registrar la inscripción: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Inscripción registrada con éxito. ID: " + idGenerado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                //si es socio, mostrar el carnet
                if (rdoSocio.Checked)
                {
                    PersonasDatos pd = new PersonasDatos();
                    DataTable personaDatos = pd.BuscarPersonaPorId(IdPersona);

                    string nombre = personaDatos.Rows[0]["nombre"].ToString();
                    string apellido = personaDatos.Rows[0]["apellido"].ToString();
                    string dni = personaDatos.Rows[0]["dni"].ToString();
                    string vencimiento = vencimientoCalc.ToShortDateString();

                    frmCarnetSocio carnet = new frmCarnetSocio(nombre, apellido, dni, idGenerado.ToString(), vencimiento);
                    carnet.ShowDialog();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Borra la persona creada en la base de datos
            

            
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

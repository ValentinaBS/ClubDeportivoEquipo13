using ClubDeportivoEquipo13.Datos;
using ClubDeportivoEquipo13.Enums;
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
            // Enum - Forma de pago
            AyudanteEnums.BindEnumToComboBox<Enums.TiposDePago>(cboFormaPago);
            // Enum - Tipos de actividad
            AyudanteEnums.BindEnumToComboBox<TiposDeActividades>(cboActividad);

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
                        // le agrega 1 mes a la fecha de pago, indicando el vencimiento
                        FechaVencimiento = dtpFecha.Value.AddMonths(1),
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
                // Mostrar comprobante o carnet según corresponda
                PersonasDatos pd = new PersonasDatos();
                DataTable personaDatos = pd.BuscarPersonaPorId(IdPersona);

                //datos para el comprobante o carnet
                string nombre = personaDatos.Rows[0]["nombre"].ToString();
                string apellido = personaDatos.Rows[0]["apellido"].ToString();
                string dni = personaDatos.Rows[0]["dni"].ToString();
                string monto = txtMonto.Text;
                string formaPago = cboFormaPago.Text;
                string fechaPago = DateTime.Now.ToShortDateString();
                string vencimiento = vencimientoCalc.ToShortDateString();

                //SOCIO -> CARNET + COMPROBANTE
                if(rdoSocio.Checked)
                {
                    frmCarnetSocio carnet = new frmCarnetSocio(
                        nombre,
                        apellido,
                        dni,
                        idGenerado.ToString(),
                        vencimiento
                        );
                    carnet.ShowDialog();

                    frmComprobantePago comprobante = new frmComprobantePago(
                        nombre,
                        apellido,
                        dni,
                        monto,
                        formaPago,
                        fechaPago,
                        vencimiento
                        );
                    comprobante.ShowDialog();
                }
                else //NO SOCIO -> COMPROBANTE
                {
                    frmComprobantePago comprobante = new frmComprobantePago(
                        nombre,
                        apellido,
                        dni,
                        monto,
                        formaPago,
                        fechaPago
                        );
                    comprobante.ShowDialog();
                }
                this.Close();
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
            // Habilita cambiar fecha de pago
            dtpFecha.Enabled = true;

            //Desabilita elección de Actividad y Horario
            grpNoSocios.Enabled = false;

            // Muestra opciones de cuotas
            AyudanteEnums.BindFilteredTiposDePago(cboFormaPago, hideCuotas: false);
        }

        private void cboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdoNoSocio_CheckedChanged(object sender, EventArgs e)
        {
            //Habilita elección de Actividad y Horario
            grpNoSocios.Enabled = true;

            // Bloquea cambiar fecha de pago
            dtpFecha.Enabled = false;
            //Obliga a que sea el dia de hoy
            dtpFecha.Value = DateTime.Now;

            // Esconde las opciones de cuotas
            AyudanteEnums.BindFilteredTiposDePago(cboFormaPago, hideCuotas: true);
        }

        private void frmCompletarInscripcion_Load(object sender, EventArgs e)
        {
            // Buscador de fecha, fecha minima del día de hoy
            dtpFecha.MinDate = DateTime.Now;
            // Fecha máxima, último día del mes actual
            dtpFecha.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
        }

        private void cboActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica que no sea nulo
            if (cboActividad.SelectedItem is null) return;

            var seleccion = cboActividad.SelectedItem;

            // Selecciona la propiedad "Valor" del objeto anóNIMO
            var valorProperty = seleccion.GetType().GetProperty("Valor");
            var value = valorProperty.GetValue(seleccion, null);

            // Guarda el tipo de actividad seleccionada
            TiposDeActividades actividad = (TiposDeActividades)value;

            if (actividad == TiposDeActividades.Musculacion)
            {
                AyudanteEnums.BindEnumToComboBox<HorarioMusculacion>(cboHorario);
            }
            else if (actividad == TiposDeActividades.Aparatos)
            {
                AyudanteEnums.BindEnumToComboBox<HorarioAparatos>(cboHorario);
            }
        }
    }
}

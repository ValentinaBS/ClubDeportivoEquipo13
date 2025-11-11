using ClubDeportivoEquipo13.Datos;
using ClubDeportivoEquipo13.Dominio;
using ClubDeportivoEquipo13.Entidades;
using ClubDeportivoEquipo13.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClubDeportivoEquipo13.Forms
{
    public partial class frmPagarCuota : Form
    {
        public frmPagarCuota()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            // Enum - Forma de pago
            AyudanteEnums.BindEnumToComboBox<TiposDePago>(cboFormaPago);
            // Enum - Tipos de actividad
            AyudanteEnums.BindEnumToComboBox<TiposDeActividades>(cboActividad);

        }



        private void FrmPagarCuota_Load(object sender, EventArgs e)
        {
            // Buscador de fecha, fecha minima del día de hoy
            dtpFecha.MinDate = DateTime.Now;
            // Fecha máxima, último día del mes actual
            dtpFecha.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

        }

        private void rdoMensual_CheckedChanged(object sender, EventArgs e)
        {
            // Habilita cambiar fecha de pago
            dtpFecha.Enabled = true;

            // Muestra opciones de cuotas
            AyudanteEnums.BindFilteredTiposDePago(cboFormaPago, hideCuotas: false);

            //Desabilita elección de Actividad y Horario
            grpNoSocios.Enabled = false;


        }

        private void rdoDiaria_CheckedChanged(object sender, EventArgs e)
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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
           
            // le agrega 1 mes a la fecha de pago, indicando el vencimiento
            DateTime vencimientoCalc = dtpFecha.Value.AddMonths(1);
            if (!rdoMensual.Checked && !rdoDiaria.Checked)
            {
                MessageBox.Show("Debe seleccionar el tipo de Cuota", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CuotasDatos datos = new CuotasDatos();
            var dni = txtDni.Text;
            try
            {
                
                int idGenerado = 0;
                if (rdoMensual.Checked)
                {
                    CuotaMensual cuotaMensual = new CuotaMensual
                    {
                        Monto = Convert.ToDouble(txtMonto.Text),
                        FechaPago = DateTime.Now,
                        FechaVencimiento = vencimientoCalc,
                        FormaPago = cboFormaPago.Text
                    };
                    CuotasDatos cuotasDatos = new CuotasDatos();
                    var rta = cuotasDatos.NuevaCuotaMensual(dni, cuotaMensual);
                    //MessageBox.Show("MENSUAL" + rta);
                    idGenerado = Convert.ToInt32(rta);
                }
                else if (rdoDiaria.Checked)
                {
                    ActividadDatos actividadDatos = new ActividadDatos();
                    var seleccionActividad = cboActividad.Text;
                    int seleccionHorario = (int)cboHorario.SelectedValue;
                    var actividadId = actividadDatos.BuscarActividadPorTipo(seleccionActividad, seleccionHorario);

                    CuotaDiaria cuotaDiaria = new CuotaDiaria
                    {
                        Monto = Convert.ToDouble(txtMonto.Text),
                        FechaPago = DateTime.Now,
                        FormaPago = cboFormaPago.Text,
                        IdActividad = actividadId.HasValue ? actividadId.Value : 0
                    };
                    CuotasDatos cuo = new CuotasDatos();
                    var respuesta = cuo.NuevaCuotaDiaria(dni, cuotaDiaria);
                    //MessageBox.Show("DIARIA" + respuesta);
                    idGenerado = Convert.ToInt32(respuesta);

                }

                if (idGenerado <= 0)
                {
                    MessageBox.Show("Error al crear cuota: " + idGenerado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Cuota creada con éxito. ID: " + idGenerado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                MessageBox.Show("HOLA");
                // Mostrar comprobante o carnet según corresponda
                PersonasDatos pd = new PersonasDatos();
                DataTable personaDatos = pd.BuscarPersonaPorDni(dni);
                MessageBox.Show("HOLAAA");


                //datos para el comprobante o carnet
                string nombre = personaDatos.Rows[0]["nombre"].ToString();
                string apellido = personaDatos.Rows[0]["apellido"].ToString();
                string monto = txtMonto.Text;
                string formaPago = cboFormaPago.Text;
                string fechaPago = DateTime.Now.ToShortDateString();
                string vencimiento = vencimientoCalc.ToShortDateString();
                MessageBox.Show(nombre + " " + apellido + " " + monto);

                //SOCIO -> CARNET + COMPROBANTE
                if (rdoMensual.Checked)
                {

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
            catch
            {
                
            }
            
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

        private void cboHorario_SelectedIndexChanged(object sender, EventArgs e)
        { // Pruebas
            /*
            try
            {
                int hour = (int)cboHorario.SelectedValue;
                var seleccionActividad = cboActividad.Text;
                MessageBox.Show(seleccionActividad);
            }
            catch { } */
        }
    }
}

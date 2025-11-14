using ClubDeportivoEquipo13.Datos;
using ClubDeportivoEquipo13.Dominio;
using ClubDeportivoEquipo13.Entidades;
using ClubDeportivoEquipo13.Enums;
using ClubDeportivoEquipo13.Validaciones;
using MySql.Data.MySqlClient;
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
           // dtpFecha.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

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
            if (!rdoMensual.Checked && !rdoDiaria.Checked)
            {
                MessageBox.Show("Debe seleccionar el tipo de Cuota", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("El DNI es requerido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("El monto es requerido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cboFormaPago.Text))
            {
                MessageBox.Show("La forma de pago es requerida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboFormaPago.Focus();
                return;
            }

            if (!rdoMensual.Checked && !rdoDiaria.Checked)
            {
                MessageBox.Show("Debe seleccionar el tipo de Cuota", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Additional validation for Diaria
            if (rdoDiaria.Checked)
            {
                if (string.IsNullOrWhiteSpace(cboActividad.Text))
                {
                    MessageBox.Show("La actividad es requerida para cuota diaria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboActividad.Focus();
                    return;
                }

                if (cboHorario.SelectedValue == null)
                {
                    MessageBox.Show("El horario es requerido para cuota diaria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboHorario.Focus();
                    return;
                }
            }
            // le agrega 1 mes a la fecha de pago, indicando el vencimiento
            DateTime vencimientoCalc = dtpFecha.Value.AddMonths(1);
            
            CuotasDatos datos = new CuotasDatos();
            var dni = txtDni.Text;
            //Consulta si la fecha electa no tiene una cuota vigente

            var tieneVencida = datos.ConsultarVencimientoSocio(dni, dtpFecha.Value.Date);


            try
            {
                int idGenerado = 0;

                if (rdoMensual.Checked)
                {
                    if (tieneVencida.resultado == 0)
                    {
                        MessageBox.Show("Error al crear cuota: La última cuota aún está vigente hasta: "
                            + tieneVencida.fecha.Date, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    CuotaMensual cuotaMensual = new CuotaMensual
                    {
                        Monto = Convert.ToDouble(txtMonto.Text),
                        FechaPago = dtpFecha.Value,
                        FechaVencimiento = vencimientoCalc,
                        FormaPago = cboFormaPago.Text
                    };
                    
                    var rta = datos.NuevaCuotaMensual(dni, cuotaMensual);
                    idGenerado = Convert.ToInt32(rta);
                    if (idGenerado == -1)
                    {
                        MessageBox.Show("Error al crear cuota: La persona es No-Socio (Cuota Diaria)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    else if (idGenerado == 0)
                    {
                        MessageBox.Show("Error al crear cuota: La Persona no está registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Cuota Mensual creada con éxito. ID: " + idGenerado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
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
                    idGenerado = Convert.ToInt32(respuesta);
                    if (idGenerado == -1)
                    {
                        MessageBox.Show("Error al crear cuota: La persona es Socio/a (Cuota Mensual)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    else if (idGenerado == 0)
                    {
                        MessageBox.Show("Error al crear cuota: La Persona no está registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Cuota Diaria creada con éxito. ID: " + idGenerado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }

                // Mostrar comprobante o carnet según corresponda
                PersonasDatos pd = new PersonasDatos();
                DataTable personaDatos = pd.BuscarPersonaPorDni(dni);


                //datos para el comprobante o carnet
                string nombre = personaDatos.Rows[0]["nombre"].ToString();
                string apellido = personaDatos.Rows[0]["apellido"].ToString();
                string monto = txtMonto.Text;
                string formaPago = cboFormaPago.Text;
                string fechaPago = dtpFecha.Value.ToShortDateString();
                string vencimiento = vencimientoCalc.ToShortDateString();

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


        private void txtDni_TextChanged(object sender, KeyPressEventArgs e)
        {
            AyudanteValidador.PermitirSoloNumeros(e, txtDni, toolTipDni);
            AyudanteValidador.LimiteDeCaracteres(e, txtDni, toolTipDni, 8);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            AyudanteValidador.PermitirSoloNumeros(e, txtMonto, toolTipMonto);
        }

       
    }
}

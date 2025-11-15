using ClubDeportivoEquipo13.Datos;
using ClubDeportivoEquipo13.Dominio;
using ClubDeportivoEquipo13.Enums;
using ClubDeportivoEquipo13.Validaciones;
using System;
using System.Data;
using System.Windows.Forms;


namespace ClubDeportivoEquipo13.Forms
{
    public partial class frmPagarCuota : Form
    {
        public frmPagarCuota()
        {
            InitializeComponent();
            InitializeComboBox();
            this.AcceptButton = btnRegistrarPago;
            this.CancelButton = btnCancelar;
        }

        private void InitializeComboBox()
        {
            // Enum - Forma de pago
            AyudanteEnums.BindEnumToComboBox<TiposDePago>(cboFormaPago);
        }



        private void FrmPagarCuota_Load(object sender, EventArgs e)
        {
            // Buscador de fecha, fecha minima del día de hoy
            dtpFecha.MinDate = DateTime.Now;
            // Fecha máxima, último día del mes actual
            dtpFecha.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);


            // Carga las actividades de la base de datos al combobox
            ActividadDatos actividadDatos = new ActividadDatos();
            DataTable actividades = actividadDatos.ObtenerTodasLasActividades();
            cboActividad.DataSource = actividades;
            cboActividad.DisplayMember = "nombreActividad";  // descripción
            cboActividad.ValueMember = "idActividad";        // valor interno
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

            if (rdoDiaria.Checked)
            {
                if (string.IsNullOrWhiteSpace(cboActividad.Text))
                {
                    MessageBox.Show("La actividad es requerida para cuota diaria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboActividad.Focus();
                    return;
                }
            }
            // le agrega 1 mes a la fecha de pago, indicando el vencimiento
            DateTime vencimientoCalc = dtpFecha.Value.AddMonths(1);
            
            CuotasDatos datos = new CuotasDatos();
            var dni = txtDni.Text;
            //Consulta si la fecha electa no tiene una cuota vigente

            // 
            var tieneVencida = datos.ConsultarVencimientoSocio(dni, dtpFecha.Value.Date);

            try
            {
                int idGenerado = 0;

                if (rdoMensual.Checked)
                {
                    if (tieneVencida.resultado == 0)
                    {
                        MessageBox.Show("La última cuota aún está vigente hasta el: "
                            + tieneVencida.fecha.Date.ToString("dd/MM/yyyy"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        rdoDiaria.Checked = true;
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
                    // Valor del combobox de actividad
                    int idActividad = (int)cboActividad.SelectedValue;

                    //Verificar si la actividad ya fue comprada hoy
                    CuotasDatos cuotasDatos = new CuotasDatos();
                    int actividadRepetida = cuotasDatos.ConsultarActividadRepetida(dni, idActividad, DateTime.Now);

                    if (actividadRepetida > 0)
                    {
                        MessageBox.Show("Error: Ya compró esta actividad el día de hoy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    CuotaDiaria cuotaDiaria = new CuotaDiaria
                    {
                        Monto = Convert.ToDouble(txtMonto.Text),
                        FechaPago = DateTime.Now,
                        FormaPago = cboFormaPago.Text,
                        IdActividad = idActividad
                    };
                    CuotasDatos cuo = new CuotasDatos();
                    var respuesta = cuo.NuevaCuotaDiaria(dni, cuotaDiaria);
                    idGenerado = Convert.ToInt32(respuesta);
                    if (idGenerado == -1)
                    {
                        MessageBox.Show("Error al crear cuota: La persona es Socio/a (Cuota Mensual)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rdoMensual.Checked = true;
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

                // Mostrar comprobante según corresponda
                PersonasDatos pd = new PersonasDatos();
                DataTable personaDatos = pd.BuscarPersonaPorDni(dni);


                //datos para el comprobante 
                string nombre = personaDatos.Rows[0]["nombre"].ToString();
                string apellido = personaDatos.Rows[0]["apellido"].ToString();
                string monto = txtMonto.Text;
                string formaPago = cboFormaPago.Text;
                string fechaPago = dtpFecha.Value.ToShortDateString();
                string vencimiento = vencimientoCalc.ToShortDateString();

                //SOCIO -> COMPROBANTE/S
                if (rdoMensual.Checked)
                {
                    // Toma el valor numerico del enum de Forma de pago, para detectar cuotas
                    var seleccionPago = cboFormaPago.SelectedItem;
                    var valorProperty = seleccionPago.GetType().GetProperty("Valor");

                    int seleccionCuotas = (int)cboFormaPago.SelectedValue;

                    // Convierte el monto de string a double y toma dos decimales
                    double montoDouble = Math.Round(double.TryParse(monto, out double result) ? result : 0, 2);
                    // Divide el monto por la cantidad de cuotas y lo devuelve en string
                    //string montoDividido = (montoDouble / seleccionCuotas).ToString();

                    int cantCuotas = seleccionCuotas;
                    double montoTotal = montoDouble;
                    double montoCuotas = Math.Round(montoDouble / cantCuotas, 2);

                    frmComprobantePago comprobante = new frmComprobantePago(
                        nombre,
                        apellido,
                        dni.Insert(5, ".").Insert(2, "."), // Pone los puntitos al documento
                        montoTotal,
                        formaPago,
                        fechaPago,
                        vencimiento,
                        cantCuotas,
                        montoCuotas
                    );
                    comprobante.ShowDialog();
                
                }
                else //NO SOCIO -> COMPROBANTE
                {
                    double montoDouble = Math.Round(double.Parse(monto), 2);

                    frmComprobantePago comprobante = new frmComprobantePago(
                        nombre,
                        apellido,
                        dni,
                        montoDouble,
                        formaPago,
                        fechaPago
                        );
                    comprobante.ShowDialog();
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error inesperado: ");
            }
            
        }

        private void cboActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica que no sea nulo
            if (cboActividad.SelectedItem is null) return;
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

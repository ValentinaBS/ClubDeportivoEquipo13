using ClubDeportivoEquipo13.Datos;
using ClubDeportivoEquipo13.Dominio;
using ClubDeportivoEquipo13.Enums;
using ClubDeportivoEquipo13.Validaciones;
using System;
using System.Data;
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
            // Carga Enum - Forma de pago
            AyudanteEnums.BindEnumToComboBox<TiposDePago>(cboFormaPago);
        }

        private void ConfirmarSalida()
        {
            // Pregunta de confirmacion a cancelar.
            System.Media.SystemSounds.Beep.Play();
            DialogResult result = MessageBox.Show(
                "¿Realmente desea cancelar? Se borraran todos los cambios.",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                PersonasDatos datos = new PersonasDatos();

                // Borrar persona creada previamente
                datos.EliminarUltimaPersona();

                // Mensajes de confirmación si se borró o no    
                bool fueEliminado = datos.EliminarUltimaPersona();

                if (fueEliminado)
                {
                    MessageBox.Show("Se borraron los datos.");
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna persona para eliminar");
                }

                this.Hide(); // Cierra el formulario sin crear instancias duplicadas
            }
            // Si elige No, simplemente regresa al formulario
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
          
            // le agrega 1 mes a la fecha de pago, indicando el vencimiento
            DateTime vencimientoCalc = dtpFecha.Value.AddMonths(1);
            if (!rdoSocio.Checked && !rdoNoSocio.Checked)
            {
                MessageBox.Show("Debe seleccionar tipo de inscripción.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(cboFormaPago.Text == "")
            {
                MessageBox.Show("Debe seleccionar una forma de pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            
            ActividadDatos actividadDatos = new ActividadDatos();
           
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
                    int idActividad = (int)cboActividad.SelectedValue;

                    // Crear objeto NoSocio con la primera cuota diaria
                    NoSocio noSocio = new NoSocio
                    {
                        IdPersona = IdPersona,
                        Cuota = new CuotaDiaria
                        {
                            Monto = Convert.ToDouble(txtMonto.Text),
                            FechaPago = dtpFecha.Value,
                            FormaPago = cboFormaPago.Text,
                            IdActividad = idActividad
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

                this.Hide();

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
                        dni.Insert(5, ".").Insert(2, "."), // Pone los puntitos al documento
                        idGenerado.ToString(),
                        vencimiento
                        );
                    carnet.ShowDialog();


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
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ConfirmarSalida();
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


            // Carga las actividades de la base de datos al combobox
            ActividadDatos actividadDatos = new ActividadDatos();
            DataTable actividades = actividadDatos.ObtenerTodasLasActividades();
            cboActividad.DataSource = actividades;
            cboActividad.DisplayMember = "nombreActividad";  // descripción
            cboActividad.ValueMember = "idActividad";        // valor interno
        }

        private void cboActividad_SelectedIndexChanged(object sender, EventArgs e)
        {   
            // Verifica que no sea nulo
            if (cboActividad.SelectedItem is null) return;

            var seleccion = cboActividad.SelectedItem;

        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validación de campo
            AyudanteValidador.PermitirSoloNumeros(e, txtMonto, toolTipMonto);
        }


        private void frmCompletarInscripcion_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

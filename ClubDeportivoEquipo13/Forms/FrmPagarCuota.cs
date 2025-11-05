using ClubDeportivoEquipo13.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Debe completar el campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

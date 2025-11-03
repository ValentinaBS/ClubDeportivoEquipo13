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
    public partial class frmPagarCuota : Form
    {
        public frmPagarCuota()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            // Forma de pago
            cboFormaPago.Items.AddRange(
                Enum.GetValues(typeof(Datos.TiposDePago))
                    .Cast<Datos.TiposDePago>()
                    .Select(v => GetEnumDescription(v))
                    .ToArray()
            );

            // Tipo de registro
            cboPersona.Items.AddRange(
                Enum.GetValues(typeof(Datos.TiposDeRegistro))
                    .Cast<Datos.TiposDeRegistro>()
                    .Select(v => GetEnumDescription(v))
                    .ToArray()
            );
        }
        private string GetEnumDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attr = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attr?.Description ?? value.ToString();
        }

        private void FrmPagarCuota_Load(object sender, EventArgs e)
        {

        }

        private void rdoMensual_CheckedChanged(object sender, EventArgs e)
        {
            lblFechaDePago.Visible = true;
            dtpFecha.Visible = true;
        }

        private void rdoDiaria_CheckedChanged(object sender, EventArgs e)
        {
            lblFechaDePago.Visible = false;
            dtpFecha.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoEfectivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

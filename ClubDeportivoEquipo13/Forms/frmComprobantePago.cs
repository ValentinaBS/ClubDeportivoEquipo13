using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivoEquipo13.Forms
{
    public partial class frmComprobantePago : Form
    {
        public frmComprobantePago(string nombre, string apellido, string dni, 
            string monto, string forma, string fecha, string vencimiento = ""
            , int cuota = 1, int cantCuotas = 1)
        {
            InitializeComponent();

            lblNombreCompleto.Text = nombre + " " + apellido;
            lblDni.Text = dni;
            lblMontoAbonado.Text = "$ " + monto;
            lblFechaPago.Text = fecha;
            lblFormaPago.Text = forma;

            if (cantCuotas != 1)
            {
                lblCuotas.Visible = true;
                lblCuotas.Text = "Cuota N°" + cuota + " de " + cantCuotas;
            }
            else
            {
                lblCuotas.Visible = false;
            }

            if (string.IsNullOrEmpty(vencimiento))
            {
                lblTituloValido.Visible = false;
                lblFechaValido.Visible = false;
            }
            else 
            {
                lblTituloValido.Visible = true;
                lblFechaValido.Visible = true;
                lblFechaValido.Text = vencimiento;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                // Oculta botones u otros elementos innecesarios
                btnImprimir.Visible = false;

                PrintDocument pd = new PrintDocument();
                pd.PrintPage += (s, ev) =>
                {
                    Bitmap bmp = new Bitmap(this.Width, this.Height);
                    this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
                    ev.Graphics.DrawImage(bmp, 0, 0);
                    ev.HasMorePages = false;
                    bmp.Dispose();
                };

                pd.Print();

                btnImprimir.Visible = true;

                MessageBox.Show("Operación exitosa. Comprobante impreso.", "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                this.WindowState = FormWindowState.Normal;
                this.BringToFront();
                this.Activate();

                // referencia al menú
                Form menu = Application.OpenForms["frmMenu"];

                if (menu != null)
                {
                    // Si el menú está minimizado, lo restauramos
                    if (menu.WindowState == FormWindowState.Minimized)
                        menu.WindowState = FormWindowState.Normal;

                    menu.Show();
                    menu.BringToFront();
                    menu.Activate();
                }
                // Cerrar el comprobante después de restaurar el menú
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}

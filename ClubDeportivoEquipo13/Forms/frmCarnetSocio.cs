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
    public partial class frmCarnetSocio : Form
    {
        public frmCarnetSocio(string nombre, string apellido, string dni, string idSocio, string vencimiento)
        {
            InitializeComponent();
            lblNombreCompleto.Text = nombre + " " + apellido;
            lblDni.Text = dni;
            lblIdSocio.Text = idSocio;
            lblVencimieto.Text = vencimiento;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
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

                MessageBox.Show("Carnet impreso correctamente.", "Aviso del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                this.WindowState = FormWindowState.Normal;
                this.BringToFront();
                this.Activate();
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

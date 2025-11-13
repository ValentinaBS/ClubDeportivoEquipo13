using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivoEquipo13.Validaciones
{
    public static class AyudanteValidador
    {

        public static void PermitirSoloNumeros(KeyPressEventArgs e, TextBox textBox, ToolTip toolTip = null)
        {
            if (char.IsControl(e.KeyChar)) return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();

                if (toolTip != null && textBox != null)
                {

                    toolTip.Show("Solo ingresar números", textBox, 1000);
                }
            }
        }

        public static void PermitirSoloLetras(KeyPressEventArgs e, TextBox textBox, ToolTip toolTip = null)
        {
            if (char.IsControl(e.KeyChar)) return;

            // Solo letras y espacios (para segundo o tercer nombre)
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();

                if (toolTip != null && textBox != null)
                {
                    toolTip.Show("Solo ingresar letras", textBox, 1000);
                }
            }
        }

       

    }
}

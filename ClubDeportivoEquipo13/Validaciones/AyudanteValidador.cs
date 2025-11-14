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

        public static void LimiteDeCaracteres(KeyPressEventArgs e, TextBox textBox, ToolTip toolTip = null, int numeroMaximo = 50)
        {
            // Permitir teclas de control (backspace, delete, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Si ya alcanzó el máximo de caracteres, bloquear nueva escritura
            if (textBox.Text.Length >= numeroMaximo)
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();

                if (toolTip != null)
                {
                    toolTip.Show($"Máximo {numeroMaximo} caracteres permitidos", textBox, 1000);
                }
            }
        }



        public static string ValidarNombre(string input)
        {

            // Hace TRIM y saca espacios múltiples
            string[] palabras = input.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Filtrar palabras con mínimo 2 letras y capitalizar
            var palabrasValidas = new List<string>();

            foreach (string palabra in palabras)
            {
                if (palabra.Length >= 2)
                {
                    string palabraCapitalizada = char.ToUpper(palabra[0]) + palabra.Substring(1).ToLower();
                    palabrasValidas.Add(palabraCapitalizada);
                }
                else
                {
                    return "";
                }
            }

            return palabrasValidas.Count > 0 ? string.Join(" ", palabrasValidas) : string.Empty;
        }


        public static bool ValidarDocumento(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
                return false;

            // Verifica que tengo 8 dígitos 
            return dni.Length == 8;
        }

        public static string ValidarEmail(string input)
        {
            string email = input.Trim();

            try
            {
                // Formato básico de email
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (System.Text.RegularExpressions.Regex.IsMatch(email, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    return email; // Retorna el email
                }
            }
            catch
            {
                // Si hay error en la validación, retorna vacío
            }

            return ""; // Retorna vacío si no es válido
        }

        public static string ValidarTelefono(string input)
        {
            string limpio = input.Trim();

            // Validar: 8-10 dígitos, todos números, y no empieza con 0
            if (limpio.Length >= 8 && limpio.Length <= 10 &&
                limpio.All(char.IsDigit) &&
                limpio[0] != '0')
            {
                return limpio;
            }

            return string.Empty;
        }

        public static string ValidarDireccion(string input)
        {
            string direccion = input.Trim();

            if (direccion.Length < 5 || direccion.Length > 100)
                return string.Empty;

            foreach (char c in direccion)
            {
                if (!(char.IsLetterOrDigit(c) ||
                      c == ' ' || c == '.' || c == ',' || c == '#' ||
                      c == '-' || c == '/' || c == '°' || c == 'ª'))
                {
                    return string.Empty;
                }
            }

            return direccion;
        }

    }
}

using ClubDeportivoEquipo13.Forms;
using ClubDeportivoEquipo13.Datos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClubDeportivoEquipo13
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmConexionDatos frmConexion = new frmConexionDatos();
            if (frmConexion.ShowDialog() == DialogResult.OK)
            {
                Conexion.getInstancia().Configurar(frmConexion.Servidor, frmConexion.Usuario, frmConexion.Clave, frmConexion.Puerto);
                Application.Run(new frmLogin());
            }
            else
            {
                MessageBox.Show("La aplicación se cerrará porque no se configuró correctamente la conexión.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

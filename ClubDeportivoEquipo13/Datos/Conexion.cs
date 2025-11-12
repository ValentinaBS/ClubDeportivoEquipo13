using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ClubDeportivoEquipo13.Datos
{
    public class Conexion
    {
        private string Database;
        private string server;
        private string port;
        private string user;
        private string clave;
        private static Conexion instancia = null;
        
        private Conexion() {

            bool correcto = false;
            int mensaje;

            string T_server = "Server";
            string T_user = "User";
            string T_password = "Password";
            string T_port = "Port";

            while (correcto != true)
            {
                // Armamos los cuadros de dialogo para el ingreso de datos
                T_server = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
                T_user = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
                T_password = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese clave", "DATOS DE INSTALACIÓN MySQL");
                T_port = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese puerto", "DATOS DE INSTALACIÓN MySQL");

                mensaje = (int)MessageBox.Show("su ingreso: SERVIDOR = " + T_server +
                    " USUARIO: " + T_user +
                    " CLAVE: " + T_password +
                    " PUERTO= " + T_port, 
                    "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mensaje != 6) // el valor 6 corresponde al SI
                {
                    MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }
            }

            this.Database = "equipo13_coma";
            this.server = T_server; // "localhost";
            this.user = T_user; // "root";
            this.clave = T_password; // "";
            this.port = T_port; //"3306";
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString =
                    "Server=" + this.server + ";" +
                    "Database=" + this.Database + ";" +
                    "User Id=" + this.user + ";" +
                    "Password=" + this.clave + ";" +
                    "Port=" + this.port + ";";

                //return cadena;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la conexión: " + ex.Message);
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
        }
    }
}

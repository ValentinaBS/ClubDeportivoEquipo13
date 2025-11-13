using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ClubDeportivoEquipo13.Datos
{
    public class Conexion
    {
        private static Conexion instancia = null;

        public static string Database { get; set; } = "equipo13_coma";
        public static string Server { get; set; } = "";
        public static string Port { get; set; } = "";
        public static string User { get; set; } = "";
        public static string Clave { get; set; } = "";

        private Conexion() { }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection cadena = new MySqlConnection();

            try
            {
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la conexión: " + ex.Message);
            }
        }

        public void Configurar(string server, string user , string clave, string port)
        {
            Server = server;
            User = user;
            Clave = clave;
            Port = port;
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

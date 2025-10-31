using System;
using MySql.Data.MySqlClient;

namespace ClubDeportivoEquipo13.Datos
{
    public class Conexion
    {
        private static Conexion instancia = null;

        private Conexion() { }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString =
                    "Server=localhost;" +
                    "Database=equipo13_coma;" +
                    "User Id=root;" +
                    "Password=Sebas2405;" +
                    "Port=3306;";

                return cadena;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la conexión: " + ex.Message);
            }
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

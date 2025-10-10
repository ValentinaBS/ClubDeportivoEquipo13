using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoEquipo13.Datos
{
    public class Usuarios
    {
        public DataTable Log_Usu(string usuario, string clave)
        {
            DataTable dt = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("Login", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_usuario", MySqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("p_clave", MySqlDbType.VarChar).Value = clave;

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(dt);
            }
            catch
            {
                // devolver dt vacío en caso de error
            }
            return dt;
        }
    }
}

using ClubDeportivoEquipo13.Dominio;
using ClubDeportivoEquipo13.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivoEquipo13.Datos
{
    public class ActividadDatos
    {

        public DataTable ObtenerTodasLasActividades()
        {
            /*
             * Método para obtener todas las actividades de la base de datos a los comboboxes
             * de Completar inscripción y Pagar cuota
             */
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection cn = Conexion.getInstancia().CrearConexion())
                {
                    cn.Open();
                    string query = "SELECT idActividad, nombreActividad FROM actividad;";
                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las actividades: " + ex.Message);
            }
            return tabla;
        }

    }
}

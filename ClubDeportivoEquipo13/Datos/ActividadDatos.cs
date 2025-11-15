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

        public int? BuscarActividadPorTipo(string tipoActividad, int horario)
        {
            /* La base de datos de actividad es muy básica, nos parecio mas fácil este sistema.
             Tenemos dos tipos de actividades (Musculación y Aparatos) y cada una tiene horarios fijos.
             Por lo tanto, para buscar el ID de la actividad, buscamos que el tipo y el  coincidan
            y ese ID se lo asignamos a la cuota, que estará asociada á un no-socio.
            Teniendo record de sus compras.
             */

            try
            {
                using (MySqlConnection cn = Conexion.getInstancia().CrearConexion())
                {
                    cn.Open();
                    TimeSpan hora = new TimeSpan(horario, 0, 0);

                    string query = @"SELECT idActividad
                             FROM actividad
                             WHERE horario = @hora
                             AND nombreActividad = @nombreActividad;";

                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@hora", hora);
                    cmd.Parameters.AddWithValue("@nombreActividad", tipoActividad);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        return reader.GetInt32("idActividad");
                    }
                    else
                    {

                        // No hay actividad encontrada
                        return null;
                    }
                }
            }
            catch
            {
                // En caso de error, devuelve null
                return null;
            }
        }
    }
}

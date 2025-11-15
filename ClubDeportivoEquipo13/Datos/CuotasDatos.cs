using ClubDeportivoEquipo13.Dominio;
using ClubDeportivoEquipo13.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivoEquipo13.Datos
{
    public class CuotasDatos
    {
        public string NuevaCuotaMensual(string dni, CuotaMensual cuota)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                int resultado;
                try
                {
                    sqlCon.Open();
                    MySqlCommand cmd = new MySqlCommand("NuevaCuotaMensual", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_dni", MySqlDbType.VarChar).Value = dni;
                    cmd.Parameters.Add("p_monto", MySqlDbType.Double).Value = cuota.Monto;
                    cmd.Parameters.Add("p_fechaPago", MySqlDbType.Date).Value = cuota.FechaPago;
                    cmd.Parameters.Add("p_fechaVencimiento", MySqlDbType.Date).Value = cuota.FechaVencimiento;
                    cmd.Parameters.Add("p_formaPago", MySqlDbType.VarChar).Value = cuota.FormaPago;

                    MySqlParameter idParam = new MySqlParameter("p_rta", MySqlDbType.Int32)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(idParam);

                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToInt32(idParam.Value);

                    return resultado.ToString();
                }
                catch (Exception ex)
                {
                    return $"Error Interno: {ex.Message}";
                }

            }
        }

        public string NuevaCuotaDiaria(string dni, CuotaDiaria cuota)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();
                    MySqlCommand cmd = new MySqlCommand("NuevaCuotaDiaria", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_dni", MySqlDbType.VarChar).Value = dni;
                    cmd.Parameters.Add("p_monto", MySqlDbType.Double).Value = cuota.Monto;
                    cmd.Parameters.Add("p_fechaPago", MySqlDbType.Date).Value = cuota.FechaPago;
                    cmd.Parameters.Add("p_formaPago", MySqlDbType.VarChar).Value = cuota.FormaPago;
                    cmd.Parameters.Add("p_idActividad", MySqlDbType.VarChar).Value = cuota.IdActividad;

                    MySqlParameter ParId = new MySqlParameter("p_rta", MySqlDbType.Int32)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(ParId);

                    cmd.ExecuteNonQuery();

                    int resultado = Convert.ToInt32(ParId.Value);

                    return resultado.ToString();
                }
                catch (Exception ex)
                {
                    return $"Error Interno: {ex.Message}";
                }
            }
        }

        public int ConsultarActividadRepetida(string dni, int idActividad, DateTime fechaPago)
        {
            try
            {
                using (MySqlConnection cn = Conexion.getInstancia().CrearConexion())
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        "SELECT COUNT(*) " +
                        "FROM cuotadiaria cd " +
                        "INNER JOIN nosocio ns ON cd.idNoSocio = ns.idNoSocio " +
                        "INNER JOIN persona p " +
                        "ON ns.idPersona = p.idPersona " +
                        "WHERE p.dni = @dni " +
                        "AND cd.idActividad = @idActividad " +
                        "AND cd.fechaPago = @fechaPago;", cn);

                    cmd.Parameters.AddWithValue("@dni", dni);
                    cmd.Parameters.AddWithValue("@idActividad", idActividad);
                    cmd.Parameters.AddWithValue("@fechaPago", fechaPago.Date);

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        return Convert.ToInt32(resultado); // Devuelve el número de registros encontrados
                    }
                    return 0; // No se encontraron registros
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar actividad repetida: " + ex.Message);
                return -1; // Error en el sistema
            }
        }

        public (int resultado, DateTime fecha) ConsultarVencimientoSocio(string dni, DateTime fechaCuota)
        {
            /* 
             Para comprar nuevas cuotas mensuales, se compara la ultima fecha de vencimiento
            de la tabla socios, con la fecha que se quiere pagar
             */

            using (MySqlConnection cn = Conexion.getInstancia().CrearConexion())
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT fechaVencimiento " +
                    "FROM socio WHERE idPersona = (SELECT idPersona FROM persona WHERE dni = @dni)", cn);
                cmd.Parameters.AddWithValue("@dni", dni);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    DateTime fechaVencimiento = Convert.ToDateTime(resultado).Date;
                    if (fechaCuota > fechaVencimiento)
                    {
                        return (1, fechaVencimiento); // La ultima cuota está vencida, puede pagar
                    }
                    else
                    {
                        return (0, fechaVencimiento); // La ultima cuota no está vencida, no puede pagar
                    }
                }
                return (-1, fechaCuota); // Error en el sistema.
            }


        }

    }
}

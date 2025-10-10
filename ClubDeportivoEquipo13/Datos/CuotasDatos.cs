using ClubDeportivoEquipo13.Dominio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoEquipo13.Datos
{
    public class CuotasDatos
    {
        public string NuevaCuotaMensual(CuotaMensual cuota)
        {
            string salida;
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();
                    MySqlCommand cmd = new MySqlCommand("NuevaCuotaMensual", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_idSocio", MySqlDbType.Int32).Value = cuota.IdSocio;
                    cmd.Parameters.Add("p_monto", MySqlDbType.Double).Value = cuota.Monto;
                    cmd.Parameters.Add("p_fechaPago", MySqlDbType.Date).Value = cuota.FechaPago;
                    cmd.Parameters.Add("p_fechaVencimiento", MySqlDbType.Date).Value = cuota.FechaVencimiento;
                    cmd.Parameters.Add("p_formaPago", MySqlDbType.VarChar).Value = cuota.FormaPago;

                    cmd.ExecuteNonQuery();
                    salida = "1";
                }
                catch (Exception ex)
                {
                    salida = ex.Message;
                }
            }
            return salida;
        }

        public string NuevaCuotaDiaria(CuotaDiaria cuota)
        {
            string salida;
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();
                    MySqlCommand cmd = new MySqlCommand("NuevaCuotaDiaria", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_idNoSocio", MySqlDbType.Int32).Value = cuota.IdNoSocio;
                    cmd.Parameters.Add("p_monto", MySqlDbType.Double).Value = cuota.Monto;
                    cmd.Parameters.Add("p_fechaPago", MySqlDbType.Date).Value = cuota.FechaPago;
                    cmd.Parameters.Add("p_formaPago", MySqlDbType.VarChar).Value = cuota.FormaPago;

                    cmd.ExecuteNonQuery();
                    salida = "1";
                }
                catch (Exception ex)
                {
                    salida = ex.Message;
                }
            }
            return salida;
        }
    }
}

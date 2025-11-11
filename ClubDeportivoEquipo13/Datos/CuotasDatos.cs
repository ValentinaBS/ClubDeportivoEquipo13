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
    {/*
        public string NuevaCuotaMensual(string dni, CuotaMensual cuota)
        {
            string salida;
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
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

                    MySqlParameter ParId = new MySqlParameter("p_rta", MySqlDbType.Int32)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(ParId);

                    cmd.ExecuteNonQuery();
                    int idSocio = Convert.ToInt32(ParId.Value);

                    salida = idSocio.ToString();
                }
                catch (Exception ex)
                {
                    salida = ex.Message;
                }
            }
            return salida;
        }*/

        public string NuevaCuotaMensual(string dni, CuotaMensual cuota)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
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

                    MySqlParameter ParId = new MySqlParameter("p_rta", MySqlDbType.Int32)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(ParId);

                    MySqlParameter ParIdPersona = new MySqlParameter("p_idPersona", MySqlDbType.Int32)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(ParIdPersona);

                    cmd.ExecuteNonQuery();

                    int resultado = Convert.ToInt32(ParId.Value);

                    // Handle the result properly
                    if (resultado > 0)
                        return $"Cuota mensual creada. ID CUOTA: {resultado}";
                    else if (resultado == 0)
                        return "Error: Persona no registrada";
                    else if (resultado == -1)
                        return "Error: Persona no es socio";
                    else
                        return "Error desconocido";
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

                    MySqlParameter ParIdPersona = new MySqlParameter("p_idPersona", MySqlDbType.Int32)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(ParIdPersona);

                    cmd.ExecuteNonQuery();

                    int resultado = Convert.ToInt32(ParId.Value);

                    // Handle the result properly
                    if (resultado > 0)
                        return $"Cuota diaria creada. ID CUOTA: {resultado}";
                    else if (resultado == 0)
                        return "Error: Persona no registrada";
                    else if (resultado == -1)
                        return "Error: Persona no es No-Socio";
                    else
                        return "Error desconocido";
                }
                catch (Exception ex)
                {
                    return $"Error Interno: {ex.Message}";
                }
            }
        }
    }
}

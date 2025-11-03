using ClubDeportivoEquipo13.Dominio;
using ClubDeportivoEquipo13.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoEquipo13.Datos
{
    public class PersonasDatos
    {
        public int NuevaPersona(E_Persona persona)
        {
            int idPersona = 0;
            try
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("NuevaPersona", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_nombre", MySqlDbType.VarChar).Value = persona.Nombre;
                    cmd.Parameters.Add("p_apellido", MySqlDbType.VarChar).Value = persona.Apellido;
                    cmd.Parameters.Add("p_dni", MySqlDbType.VarChar).Value = persona.Dni;
                    cmd.Parameters.Add("p_telefono", MySqlDbType.VarChar).Value = persona.Telefono ?? "";
                    cmd.Parameters.Add("p_direccion", MySqlDbType.VarChar).Value = persona.Direccion ?? "";
                    cmd.Parameters.Add("p_email", MySqlDbType.VarChar).Value = persona.Email ?? "";
                    cmd.Parameters.Add("p_ficha", MySqlDbType.Int32).Value = persona.FichaMedica;

                    MySqlParameter idParam = new MySqlParameter("p_rta", MySqlDbType.Int32)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(idParam);

                    sqlCon.Open();
                    cmd.ExecuteNonQuery();

                    idPersona = Convert.ToInt32(idParam.Value);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear persona: " + ex.Message);
            }
            return idPersona;
        }


        public string NuevoSocio(Socio socio)
        {
            string salida;
            try
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
                {
                    sqlCon.Open();
                    MySqlCommand cmd = new MySqlCommand("NuevoSocio", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_idPersona", MySqlDbType.Int32).Value = socio.IdPersona;
                    cmd.Parameters.Add("p_FechaVenc", MySqlDbType.Date).Value = socio.FechaVencimiento;
                    cmd.Parameters.Add("p_Monto", MySqlDbType.Double).Value = socio.Cuota.Monto;
                    cmd.Parameters.Add("p_FormaPago", MySqlDbType.VarChar).Value = socio.Cuota.FormaPago;

                    MySqlParameter ParId = new MySqlParameter("p_rta", MySqlDbType.Int32)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(ParId);

                    cmd.ExecuteNonQuery();
                    int idSocio = Convert.ToInt32(ParId.Value);

                    // Crear cuota mensual automáticamente
                    socio.Cuota.IdSocio = idSocio;
                    CuotasDatos cuo = new CuotasDatos();
                    cuo.NuevaCuotaMensual(socio.Cuota);

                    salida = idSocio.ToString();
                }
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            return salida;
        }

        public string NuevoNoSocio(NoSocio noSocio)
        {
            string salida;
            try
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
                {
                    sqlCon.Open();
                    MySqlCommand cmd = new MySqlCommand("NuevoNoSocio", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_idPersona", MySqlDbType.Int32).Value = noSocio.IdPersona;
                    cmd.Parameters.Add("p_Monto", MySqlDbType.Double).Value = noSocio.Cuota.Monto;
                    cmd.Parameters.Add("p_FormaPago", MySqlDbType.VarChar).Value = noSocio.Cuota.FormaPago;

                    MySqlParameter ParId = new MySqlParameter("p_rta", MySqlDbType.Int32)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(ParId);

                    cmd.ExecuteNonQuery();
                    int idNoSocio = Convert.ToInt32(ParId.Value);

                    // Crear cuota diaria automáticamente
                    noSocio.Cuota.IdNoSocio = idNoSocio;
                    CuotasDatos cuo = new CuotasDatos();
                    cuo.NuevaCuotaDiaria(noSocio.Cuota);

                    salida = idNoSocio.ToString();
                }
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            return salida;
        }
        public DataTable BuscarPersonaPorId(int idPersona)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection cn = Conexion.getInstancia().CrearConexion())
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT nombre, apellido, dni FROM persona WHERE idPersona = @id", cn);
                cmd.Parameters.AddWithValue("@id", idPersona);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

    }
}

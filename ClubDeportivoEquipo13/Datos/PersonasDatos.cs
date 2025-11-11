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
                    //socio.Cuota.IdSocio = idSocio;
                    //CuotasDatos cuo = new CuotasDatos();
                    //cuo.NuevaCuotaMensual(socio.Cuota);

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
                    cmd.Parameters.Add("p_IdActividad", MySqlDbType.Int32).Value = noSocio.Cuota.IdActividad;

                    MySqlParameter ParId = new MySqlParameter("p_rta", MySqlDbType.Int32)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(ParId);

                    cmd.ExecuteNonQuery();
                    int idNoSocio = Convert.ToInt32(ParId.Value);

                    // Crear cuota diaria automáticamente
                    //noSocio.Cuota.IdNoSocio = idNoSocio;
                   // CuotasDatos cuo = new CuotasDatos();
                    //cuo.NuevaCuotaDiaria(noSocio.Cuota);

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

        public DataTable BuscarPersonaPorDni(string dni)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection cn = Conexion.getInstancia().CrearConexion())
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT idPersona FROM persona WHERE dni = @dni", cn);
                cmd.Parameters.AddWithValue("@dni", dni);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable ListarSociosVencidos(DateTime fechaConsulta)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection cn = Conexion.getInstancia().CrearConexion())
                {
                    cn.Open();

                    // Filtra donde la fecha de vencimiento sea MENOR a la fecha de consulta.
                    string query = @"
                    SELECT 
                        CONCAT(p.nombre, ' ', p.apellido) AS Socio, 
                        s.idSocio AS IdSocio, 
                        s.fechaVencimiento AS FechaVencimiento
                    FROM 
                        socio s
                    JOIN 
                        persona p ON s.idPersona = p.idPersona
                    WHERE 
                        s.fechaVencimiento < @fechaConsulta";

                    MySqlCommand cmd = new MySqlCommand(query, cn);

                    cmd.Parameters.AddWithValue("@fechaConsulta", fechaConsulta.Date);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar socios vencidos: " + ex.Message);
            }
            return dt;
        }

        public bool EliminarUltimaPersona()
        {
            bool eliminado = false;

            try
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
                {
                    sqlCon.Open();

                    // Obtiene el ultimo id creado
                    string queryId = "SELECT MAX(IdPersona) FROM Persona";
                    MySqlCommand cmdGetId = new MySqlCommand(queryId, sqlCon);
                    object result = cmdGetId.ExecuteScalar();

                    if (result == DBNull.Value || result == null)
                    {
                        throw new Exception("No hay personas registradas para eliminar.");
                    }

                    int ultimoId = Convert.ToInt32(result);

                    // Borra la persona con el último id
                    string queryDelete = "DELETE FROM Persona WHERE IdPersona = @id";
                    MySqlCommand cmdDelete = new MySqlCommand(queryDelete, sqlCon);
                    cmdDelete.Parameters.AddWithValue("@id", ultimoId);

                    int filas = cmdDelete.ExecuteNonQuery();

                    if (filas > 0)
                        eliminado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar persona: " + ex.Message);
            }

            return eliminado;
        }

        /*public string NuevaCuotaDiaria(NoSocio noSocio, CuotaDiaria cuota)
        {
            string salida;
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();
                    MySqlCommand cmd = new MySqlCommand("NuevaCuotaDiaria", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_persona", MySqlDbType.Int32).Value = noSocio.IdPersona;
                    cmd.Parameters.Add("p_monto", MySqlDbType.Double).Value = cuota.Monto;
                    cmd.Parameters.Add("p_fechaPago", MySqlDbType.Date).Value = cuota.FechaPago;
                    cmd.Parameters.Add("p_formaPago", MySqlDbType.VarChar).Value = cuota.FormaPago;
                    cmd.Parameters.Add("p_idActividad", MySqlDbType.Int32).Value = cuota.IdActividad;
                    cmd.ExecuteNonQuery();
                    salida = "1";
                }
                catch (Exception ex)
                {
                    salida = ex.Message;
                }
            }
            return salida;
        } */


    }
}

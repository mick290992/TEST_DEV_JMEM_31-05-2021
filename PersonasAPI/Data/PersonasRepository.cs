using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using PersonasAPI.Models;
using System.Data.SqlClient;
using System;
using System.Globalization;

namespace PersonasAPI.Data
{
    public class PersonasRepository
    {

        private readonly string _connectionString;

        public PersonasRepository(IConfiguration configuration)
        {
            //Obtención de la cadena de conexión que se establecio en appsettings.json
            _connectionString = configuration.GetConnectionString("defaultConnection");
        }

        public async Task<List<Persona>> GetAll()
        {
            //Se inicia la conexion con SQL 
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                //Dentro de la conexión se manda a llamar al procedimiento almacenado que vamos a utilizar y la coneccón con la que lo vamos a hacer
                using (SqlCommand cmd = new SqlCommand("sp_LeerPersonaFisica", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<Persona>();
                    await sql.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response.Add(MapToValue(reader));
                        }
                    }

                    return response;
                }
            }
        }

        //Metodo que nos ayudara a mapear los registros obtenidos al ejecutar consultas que devuelven datos
        private Persona MapToValue(SqlDataReader reader)
        {
            return new Persona()
            {
                idPersonaFisica = (int)reader["IdPersonaFisica"],
                nombre = reader["Nombre"].ToString(),
                apellidoPaterno = reader["ApellidoPaterno"].ToString(),
                apellidoMaterno = reader["ApellidoMaterno"].ToString(),
                fechaNacimiento = reader["FechaNacimiento"].ToString(),
                rfc = reader["RFC"].ToString(),
                usuarioAgrega = (int)reader["UsuarioAgrega"]
            };
        }

        public async Task<Persona> GetById(int Id)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ByIDPersonaFisica", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", Id));
                    Persona response = null;
                    await sql.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            response = MapToValue(reader);
                        }
                    }

                    return response;
                }
            }
        }

        public async Task Insert(Persona p)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_AgregarPersonaFisica", sql))
                {
                    try
                    {
                        DateTime fecha = formatDate(p.fechaNacimiento);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@Nombre", p.nombre));
                        cmd.Parameters.Add(new SqlParameter("@ApellidoPaterno", p.apellidoPaterno));
                        cmd.Parameters.Add(new SqlParameter("@ApellidoMaterno", p.apellidoMaterno));
                        cmd.Parameters.Add(new SqlParameter("@FechaNacimiento", fecha));
                        cmd.Parameters.Add(new SqlParameter("@RFC", p.rfc));
                        cmd.Parameters.Add(new SqlParameter("@UsuarioAgrega", p.usuarioAgrega));

                        await sql.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        return;
                    }
                    catch (Exception e)
                    {

                        return;
                    }
                }
            }
        }

        public async Task Actualizar(Persona p)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ActualizarPersonaFisica", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IdPersonaFisica", p.idPersonaFisica));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", p.nombre));
                    cmd.Parameters.Add(new SqlParameter("@ApellidoPaterno", p.apellidoPaterno));
                    cmd.Parameters.Add(new SqlParameter("@ApellidoMaterno", p.apellidoMaterno));

                    DateTime fecha = formatDate(p.fechaNacimiento);

                    cmd.Parameters.Add(new SqlParameter("@FechaNacimiento", fecha));
                    cmd.Parameters.Add(new SqlParameter("@RFC", p.rfc));
                    cmd.Parameters.Add(new SqlParameter("@UsuarioAgrega", p.usuarioAgrega));

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }

        public async Task DeleteById(int Id)
        {
            using (SqlConnection sql = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_EliminarPersonaFisica", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IdPersonaFisica", Id));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }

        public DateTime formatDate(string fecha)
        {
            string format = "dd/MM/yyyy";
            DateTime dateFormated;
            try
            {
                dateFormated = DateTime.ParseExact(fecha, format, CultureInfo.InvariantCulture);
                return dateFormated;
            }
            catch (FormatException)
            {
                DateTime err = DateTime.ParseExact("01/01/200", format, CultureInfo.InvariantCulture);
                return err;
            }

        }


    }
}

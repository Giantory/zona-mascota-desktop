using System;
using System.Data;
using System.Data.SqlClient;
using Models;
namespace Services
{
    public class Pet:Connection
    {
        public void registerPet(int owner, int specie, int sex, string name, double weight)
        {
            // Mensajes por defecto
            this.status = 1;
            this.message = "Proceso ejecutado correctamente";
            // Proceso General
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                try
                {
                    // La conexión
                    con.Open();
                    // El comando
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.usp_register_pet";
                    // Parametros
                    cmd.Parameters.Add("@p_owner", SqlDbType.Int).Value = owner;
                    cmd.Parameters.Add("@p_specie", SqlDbType.Int).Value = specie;
                    cmd.Parameters.Add("@p_sex", SqlDbType.Int).Value = sex;
                    cmd.Parameters.Add("@p_petName", SqlDbType.VarChar,100).Value = name;
                    cmd.Parameters.Add("@p_petWeight", SqlDbType.Decimal).Value = weight;
                    cmd.Parameters.Add("@p_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@p_status", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@p_message", SqlDbType.VarChar, 1000).Direction = ParameterDirection.Output;
                    // Ejecutar el procedimiento
                    cmd.ExecuteNonQuery();
                    this.status = Convert.ToInt32(cmd.Parameters["@p_status"].Value);
                    this.message = cmd.Parameters["@p_message"].Value.ToString();
                    cmd.Dispose();
                }
                catch (Exception e)
                {
                    this.status = -1;
                    this.message = e.Message;
                }
            }
        }
        public DataTable getPets()
        {
            DataTable tb = new DataTable();
            SqlDataReader reader;
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = ("SELECT * FROM Pet");
                reader = cmd.ExecuteReader();
                tb.Load(reader);
                reader.Close();
                con.Close();
            }

            return tb;
        }
    }
}

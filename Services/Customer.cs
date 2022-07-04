using System;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace Services
{
    public class Customer: Connection
    {
        public void registerCustomer(string name, int district, string email, int dni, int phone)
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
                    cmd.CommandText = "dbo.usp_register_customer";
                    // Parametros
                    cmd.Parameters.Add("@p_name", SqlDbType.VarChar, 100).Value = name;
                    cmd.Parameters.Add("@p_district", SqlDbType.Int).Value = district;
                    cmd.Parameters.Add("@p_email", SqlDbType.VarChar, 100).Value = email;
                    cmd.Parameters.Add("@p_dni", SqlDbType.Int).Value = dni;
                    cmd.Parameters.Add("@p_phone", SqlDbType.Int).Value = phone;
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
        public DataTable getCustomers()
        {
            DataTable tb = new DataTable();
            SqlDataReader reader;
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = ("SELECT * FROM Customer");
                reader = cmd.ExecuteReader();
                tb.Load(reader);
                reader.Close();
                con.Close();
            }

            return tb;
        }

    }
}

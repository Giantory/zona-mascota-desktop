using System;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace Services
{
    public class Product:Connection
    {
        public void registerProduct(string description, int category, double purchasePrice, double salePrice)
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
                    cmd.CommandText = "dbo.usp_register_product";
                    // Parametros
                    cmd.Parameters.Add("@p_description", SqlDbType.VarChar, 100).Value = description;
                    cmd.Parameters.Add("@p_category", SqlDbType.Int).Value = category;
                    cmd.Parameters.Add("@p_purchasePrice", SqlDbType.Money).Value = purchasePrice;
                    cmd.Parameters.Add("@p_salePrice", SqlDbType.Money).Value = salePrice;
                    cmd.Parameters.Add("@p_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@p_status", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@p_message", SqlDbType.VarChar, 1000).Direction = ParameterDirection.Output;
                    // Ejecutar el procedimiento
                    cmd.ExecuteNonQuery();
                    this.status = Convert.ToInt32(cmd.Parameters["@p_status"].Value);                   
                    this.message = cmd.Parameters["@p_mensaje"].Value.ToString();
                    cmd.Dispose();
                }
                catch (Exception e)
                {
                    this.status = -1;
                    this.message = e.Message;
                }
            }
        }
        public DataTable getProducts()
        {
            DataTable tb = new DataTable();
            SqlDataReader reader;
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = ("SELECT * FROM Product");
                reader = cmd.ExecuteReader();
                tb.Load(reader);
                reader.Close();
                con.Close();
            }

            return tb;
        }
    }
}
